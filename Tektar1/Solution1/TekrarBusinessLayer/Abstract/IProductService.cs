using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarEntityLayer;

namespace TekrarBusinessLayer.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GelAll();
        void Create(Product entity);
        void Delete(Product entity);
        void Update(Product entity);
        List<Product> GetProductsByCategory(string name);
        Product GetProductsDetails(string url);
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);

    }
}
