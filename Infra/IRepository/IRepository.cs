using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.IRepository
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
    }
}
