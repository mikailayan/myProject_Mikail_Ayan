using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarDataAccessLayer.Abstract;
using TekrarEntityLayer;

namespace TekrarDataAccessLayer.Concrete
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, TekrarContext>, ICategoryRepository
    {
        public Category GetByIdWhitCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
