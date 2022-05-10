using DataAccessLayer.Concrete.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager 
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repository.GetAll();
        }
        public void CategoryAddBL(Category entity)
        {
            if (entity.CategoryName == "" || entity.CategoryName.Length <= 3 || entity.CategoryName.Length >= 51)
            {
                //hata mesajı
            }
            else
            {
                repository.Create(entity);
            }
        }
    }
}
