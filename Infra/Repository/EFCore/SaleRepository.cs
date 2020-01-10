using Entities;
using Infra.Interfaces.IRepository.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.EFCore
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(DbContext context) : base(context)
        {
        }

    }
}
