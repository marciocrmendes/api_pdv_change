using Entities;
using Infra.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Interfaces.IRepository.EFCore
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
