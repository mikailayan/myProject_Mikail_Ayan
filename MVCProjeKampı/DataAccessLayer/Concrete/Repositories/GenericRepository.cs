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
        Context c = new Context();

        DbSet<T> _context;

        public GenericRepository()
        {
            _context = c.Set<T>();
        }
        public void Delete(T entity)
        {
            _context.Remove(entity);
            c.SaveChanges();
        }

        public void Insert(T entity)
        {
            _context.Add(entity);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _context.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _context.Where(filter).ToList();
        }

        public void Update(T entity)
        {
            c.SaveChanges();
        }
    }
}
