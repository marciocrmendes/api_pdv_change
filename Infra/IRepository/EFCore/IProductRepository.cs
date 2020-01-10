using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.IRepository.EFCore
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
