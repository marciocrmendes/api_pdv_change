using Entities;
using Infra.Interfaces.IRepository.Dapper;
using Infra.Interfaces.IRepository.EFCore;
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
            IProductRepository entityRepository, 
            IProductDapperRepository dapperRepository) : base(entityRepository, dapperRepository)
        {
        }
    }
}
