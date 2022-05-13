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

        public List<Product> GetProductsByCategory(string name)
        {
            throw new NotImplementedException();
        }

        public Product GetProductsDetails(string url)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetSearchResult(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
