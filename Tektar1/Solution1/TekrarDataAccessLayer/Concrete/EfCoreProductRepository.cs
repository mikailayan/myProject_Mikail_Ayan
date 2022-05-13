using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarDataAccessLayer.Abstract;
using TekrarEntityLayer;

namespace TekrarDataAccessLayer.Concrete
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, TekrarContext>, IProductRepository
    {
        private string ConvertLower(string text)
        {
            //İstanbul Irak Üzgün Şelaler Satırarası
            text = text.Replace("I", "i");//İstanbul irak Üzgün Şelaleler Satırarası
            text = text.Replace("İ", "i");//istanbul irak Üzgün Şelaleler Satırarası
            text = text.Replace("ı", "i");//istanbul irak Üzgün Şelaleler Satirarasi

            text = text.ToLower();//istanbul irak üzgün şelaleler satirarasi
            text = text.Replace("ç", "c");
            text = text.Replace("ö", "o");
            text = text.Replace("ü", "u");
            text = text.Replace("ş", "s");
            text = text.Replace("ğ", "g");
            return text;
        }

        public List<Product> GetSearchResult(string searchString)
        {
            searchString = ConvertLower(searchString);
            using (var context = new TekrarContext())
            {
                var products = context
                    .Products
                    .Where(i => i.IsApproved && (ConvertLower(i.Name).Contains(searchString) || ConvertLower(i.Description).Contains(searchString)))
                    .ToList();
                return products;
            }
        }

        public int GetCountByCategory(string category)
        {
            using (var context = new TekrarContext())
            {
                var products = context
                    .Products
                    .Where(i => i.IsApproved)
                    .AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                    products = products
                        .Include(i => i.productCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.productCategories.Any(a => a.Category.CategoryUrl == category));
                }
                return products.Count();
            }
        }

        public List<Product> GetHomePageProducts()
        {
            using (var context = new TekrarContext())
            {
                return context
                    .Products
                    .Where(i => i.IsApproved && i.IsHome)
                    .ToList();
            }
        }

        public List<Product> GetProductsByCategory(string name ,int page, int pageSize) //gelen paramatreyi kontrol et
        {
            using (var context = new TekrarContext())
            {
                var products = context
                    .Products
                    .Where(i => i.IsApproved)
                    .AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    products = products
                        .Include(i => i.productCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.productCategories.Any(a => a.Category.CategoryUrl == name));
                }
                return products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public Product GetProductsDetails(string url)
        {
            using (var context = new TekrarContext())
            {
                return context
                    .Products
                    .Where(i => i.Url == url)
                    .Include(i => i.productCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();
            }
        }

       
    }
}
