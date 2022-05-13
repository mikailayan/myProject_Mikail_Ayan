using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarEntityLayer;

namespace TekrarDataAccessLayer.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetProductsByCategory(string name);
        Product GetProductsDetails(string url);
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);
    }
}
