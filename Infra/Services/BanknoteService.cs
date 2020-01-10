using Entities;
using Infra.Interfaces.IServices;
using Infra.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Services
{
    public class BanknoteService : Service<Banknote>, IBanknoteService
    {
        public BanknoteService(
            IRepository<Banknote> entityRepository, 
            IDapperRepository<Banknote> dapperRepository) : base(entityRepository, dapperRepository)
        {
        }
    }
}
