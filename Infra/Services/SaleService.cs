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
    public class SaleService : Service<Sale>, ISaleService
    {
        public SaleService(
            ISaleRepository entityRepository, 
            ISaleDapperRepository dapperRepository) : base(entityRepository, dapperRepository)
        {
        }
    }
}
