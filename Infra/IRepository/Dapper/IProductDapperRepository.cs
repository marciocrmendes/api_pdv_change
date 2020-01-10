using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.IRepository.Dapper
{
    public interface IProductDapperRepository : IReadableRepository<Product>
    {
    }
}
