using Infra.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public bool Add(T entity)
        {
            _context.Set<T>().Add(entity).State = EntityState.Added;
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T entity)
        {
            _context.Set<T>().Remove(entity).State = EntityState.Deleted;
            return _context.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            _context.Set<T>().Update(entity).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
