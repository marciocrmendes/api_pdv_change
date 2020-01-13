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
        private ISaleDapperRepository _dapperRepository;

        public SaleService(
            ISaleRepository entityRepository, 
            ISaleDapperRepository dapperRepository) : base(entityRepository, dapperRepository)
        {
            _dapperRepository = dapperRepository;
        }

        //public Sale GetBanknotesDetailsById(int id)
        //{
        //    return _dapperRepository.GetBanknotesDetailsById(id);
        //}
    }
}
