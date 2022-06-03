using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MikoBussBusinessLayer;
using MikoBussBusinessLayer.Concrete;
using MikoBussDataAccessLayer.Abstract;
using MikoBussDataAccessLayer.Concrete;
using MikoBussUI.EmailServices;
using MikoBussUI.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikoBussUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlite("Data Source=MikoBussDb"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(option => {

                //Password
                option.Password.RequireDigit = true; //i�aret olmak zorunda(.)
                option.Password.RequireLowercase = true; // b�y�k harf olmak zorunda
                option.Password.RequireUppercase = true; // K���k harf olmak zorunda 
                option.Password.RequiredLength = 6; //min 6 karakter olmak zorunda 

                //Lockout
                option.Lockout.MaxFailedAccessAttempts = 3;
                option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                option.Lockout.AllowedForNewUsers = true;

                //User
                option.User.RequireUniqueEmail = true;

                //SignIn
                option.SignIn.RequireConfirmedEmail = true;

            });

            services.ConfigureApplicationCookie(option => {
                option.LoginPath = "/account/login";
                option.LogoutPath = "/account/logout";
                option.AccessDeniedPath = "/account/accessdenied";
                option.ExpireTimeSpan = TimeSpan.FromMinutes(20); //cookie'nin ya�ayabilece�i zaman 
                option.SlidingExpiration = true; //cookie'nin zaman yenilenmesi
                option.Cookie = new CookieBuilder()
                {
                    HttpOnly = true, //k�t� ama�l� ki�iler taray�c� �zerinde kendi js kodlar�n� �al��t�rabilirler cookie'nin okunmas� engellenir session cookie ata��ndan korunmu� olur 
                    Name = "Mikobuss.Security.Cookie",
                    SameSite = SameSiteMode.Strict //sadece kendi bilgisayar�m g�venlik
                };
            });

            services.AddScoped<IEmailSender, SmtpEmailSender>(i => new SmtpEmailSender(
                Configuration["EmailSender:Host"],
                Configuration.GetValue<int>("EmailSender:Port"),
                Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                Configuration["EmailSender:UserName"],
                Configuration["EmailSender:Password"]
                
                ));



            services.AddScoped<ICityRepository, EfCoreCityRepository>();
            services.AddScoped<IGuzergahRepository, EfCoreGuzergahRepository>();
            services.AddScoped<ITicketRepository, EfCoreTicketRepository>();
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<ITicketService, TickerManager>();
            services.AddScoped<IGuzergahService, GuzergahManager>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "homebiletal",
                   pattern: "home/biletal",
                   defaults: new { controller = "Home", action = "BiletAl" }
                   );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
