using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarEntityLayer;

namespace TekrarBusinessLayer.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GelAll();
        void Create(Category entity);
        void Delete(Category entity);
        void Update(Category entity);
        Category GetByIdWhitCategory(int categoryId);

    }
}
