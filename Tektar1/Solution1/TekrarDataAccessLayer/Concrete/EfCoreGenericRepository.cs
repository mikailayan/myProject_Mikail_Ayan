using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarDataAccessLayer.Abstract;

namespace TekrarDataAccessLayer.Concrete
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity> where TEntity:class
        where TContext:DbContext, new()
    {

        public void Create(TEntity entity)
        {
            throw new NotImplementedException();

        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
