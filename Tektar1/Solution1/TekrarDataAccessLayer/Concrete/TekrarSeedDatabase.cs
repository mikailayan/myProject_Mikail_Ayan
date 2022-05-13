using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarDataAccessLayer.Concrete;
using TekrarEntityLayer;

namespace MiniShopApp.Data.Concrete.EfCore
{
    public static class TekrarSeedDatabase
    {
        public static void Seed()
        {
            var context = new TekrarContext();
            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                }
                if (context.ProductCategories.Count()==0)
                {
                    context.ProductCategories.AddRange(ProductCategories);
                }
                context.SaveChanges();
            }
        }
        private static Category[] Categories =
        {
            new Category() {CategoryName="Telefon",CategoryDescription="Ürünlerimiz son teknoloji ile üretilmektedir.",CategoryUrl="telefon"},
            new Category() {CategoryName="Bilgisayar",CategoryDescription="Ürünlerimiz son teknoloji ile üretilmektedir.",CategoryUrl="bilgisayar"},
            new Category() {CategoryName="Elektronik",CategoryDescription="Ürünlerimiz son teknoloji ile üretilmektedir.",CategoryUrl="elektronik"},
            new Category() {CategoryName="Beyaz Eşya",CategoryDescription="Ürünlerimiz son teknoloji ile üretilmektedir.",CategoryUrl="beyaz-esya"}
        };
        private static Product[] Products =
        {
            new Product() {Name="Samsung S10", Price=1500, Description="Bu telefon çok iyi", Url="samsung-s10", IsApproved=true, IsHome=true },
            new Product() {Name="Samsung S11", Price=1600, Description="Bu telefon çok iyi", Url="samsung-s11", IsApproved=true, IsHome=true },
            new Product() {Name="Samsung S12", Price=1700, Description="Bu telefon çok iyi", Url="samsung-s12", IsApproved=true, IsHome=true },
            new Product() {Name="Samsung S13", Price=1800, Description="Bu telefon çok iyi", Url="samsung-s13", IsApproved=true, IsHome=true },
            new Product() {Name="Xaomi Redmi 9 pro", Price=1300, Description="Bu telefon çok iyi", Url="xaomi-redmi-9-pro", IsApproved=true, IsHome=true },
            new Product() {Name="Xaomi Redmi 10 pro", Price=1400, Description="Bu telefon çok iyi", Url="xaomi-redmi-10-pro", IsApproved=true, IsHome=true },
            new Product() {Name="Xaomi Redmi 11 pro", Price=1500, Description="Bu telefon çok iyi", Url="xaomi-redmi-11-pro", IsApproved=true, IsHome=true },
            new Product() {Name="Iphone XR", Price=1200, Description="Bu telefon çok iyi", Url="ıphone-xr", IsApproved=true, IsHome=true },
            new Product() {Name="Iphone 11", Price=1300, Description="Bu telefon çok iyi", Url="ıphone-11", IsApproved=true, IsHome=true },
            new Product() {Name="Iphone 12", Price=1400, Description="Bu telefon çok iyi", Url="ıphone-12", IsApproved=true, IsHome=true },
            new Product() {Name="Iphone 13", Price=1500, Description="Bu telefon çok iyi", Url="ıphone-13", IsApproved=true, IsHome=true },
            new Product() {Name="Iphone 13 Max", Price=1600, Description="Bu telefon çok iyi", Url="ıphone-13-max", IsApproved=true, IsHome=true },
            new Product() {Name="Huawei Mate 20 Pro", Price=20000, Description="Bu telefon çok iyi", Url="huawei-mate-20-pro", IsApproved=true, IsHome=true },
        };
        private static ProductCategory[] ProductCategories =
        {
            new ProductCategory() {Product=Products[0], Category=Categories[0] },
            new ProductCategory() {Product=Products[0], Category=Categories[2] },

            new ProductCategory() {Product=Products[1], Category=Categories[0] },
            new ProductCategory() {Product=Products[1], Category=Categories[2] },

            new ProductCategory() {Product=Products[2], Category=Categories[0] },
            new ProductCategory() {Product=Products[2], Category=Categories[2] },

            new ProductCategory() {Product=Products[3], Category=Categories[0] },
            new ProductCategory() {Product=Products[3], Category=Categories[2] },

            new ProductCategory() {Product=Products[4], Category=Categories[0] },
            new ProductCategory() {Product=Products[4], Category=Categories[2] },

            new ProductCategory() {Product=Products[5], Category=Categories[1] },
            new ProductCategory() {Product=Products[6], Category=Categories[1] },
            new ProductCategory() {Product=Products[7], Category=Categories[1] },
            new ProductCategory() {Product=Products[8], Category=Categories[1] },
            new ProductCategory() {Product=Products[9], Category=Categories[1] },
            new ProductCategory() {Product=Products[10], Category=Categories[1] },
            new ProductCategory() {Product=Products[11], Category=Categories[1] },
            new ProductCategory() {Product=Products[12], Category=Categories[1] }
        };
    }
}
