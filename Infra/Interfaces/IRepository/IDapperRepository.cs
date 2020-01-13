using Entities;
using Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.IRepository
{
    public interface IDapperRepository<T> : IDisposable, IReadable<T> where T : class
    {
    }
}
