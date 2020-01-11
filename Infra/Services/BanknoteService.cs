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
    public class BanknoteService : Service<Banknote>, IBanknoteService
    {
        public BanknoteService(
            IBanknoteRepository entityRepository,
            IBanknoteDapperRepository dapperRepository) : base(entityRepository, dapperRepository)
        {
        }
    }
}
