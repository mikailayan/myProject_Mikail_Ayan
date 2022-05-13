using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarBusinessLayer.Abstract;
using TekrarDataAccessLayer.Abstract;
using TekrarEntityLayer;

namespace TekrarBusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GelAll()
        {
          return  _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetHomePageProducts()
        {
            return _productRepository.GetHomePageProducts();
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

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
