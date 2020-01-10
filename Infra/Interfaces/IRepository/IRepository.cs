using Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.IRepository
{
    public interface IRepository<T> : IReadable<T> where T : class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
    }
}
