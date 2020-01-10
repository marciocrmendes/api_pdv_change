using Entities;
using Infra.Interfaces.IServices;
using Infra.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Services
{
    public class SaleService : Service<Sale>, ISaleService
    {
        public SaleService(
            IRepository<Sale> entityRepository, 
            IDapperRepository<Sale> dapperRepository) : base(entityRepository, dapperRepository)
        {
        }
    }
}
