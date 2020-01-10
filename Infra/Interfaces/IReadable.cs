using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Interfaces
{
    public interface IReadable<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
