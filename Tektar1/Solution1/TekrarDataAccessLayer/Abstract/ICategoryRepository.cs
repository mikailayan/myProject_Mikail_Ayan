using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarEntityLayer;

namespace TekrarDataAccessLayer.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetByIdWhitCategory(int categoryId);
    }
}
