using System.Collections.Generic;

namespace Infra.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}