using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _context;
        public GenericRepository()
        {
            _context = context.Set<T>();
        }
        public void Create(T entity)
        {
            _context.Add(entity);
            context.SaveChanges();

        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.ToList();
        }

        public List<T> GetFilterList(Expression<Func<T, bool>> filter)
        {
            return _context.Where(filter).ToList();
        }

        public void Update(T entity)
        {
            context.SaveChanges();
        }
    }
}
