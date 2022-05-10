using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T: class
    {
        List<T> GetAll();
        void Delete(T entity);
        void Update(T entity);
        void Create(T entity);
        List<T> GetFilterList(Expression<Func<T, bool>> filter);
    }
}
