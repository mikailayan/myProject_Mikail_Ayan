using Microsoft.EntityFrameworkCore;
using MikoBussEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikoBussDataAccessLayer.Concrete
{
    public class MikoBussContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Guzergah> Guzergahs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MikoBussDb");
        }
    }
}
