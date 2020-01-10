using Entities;
using Infra.Interfaces.IServices;
using Infra.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(
            IRepository<Product> entityRepository, 
            IDapperRepository<Product> dapperRepository) : base(entityRepository, dapperRepository)
        {
        }
    }
}
