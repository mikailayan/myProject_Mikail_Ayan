using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekrarDataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetById(int id);

    }
}
