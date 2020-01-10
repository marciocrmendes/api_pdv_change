using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.IRepository
{
    public interface IReadableRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
