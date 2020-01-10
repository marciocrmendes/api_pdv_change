using Entities;
using Infra.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Interfaces.IRepository.Dapper
{
    public interface IBanknoteDapperRepository : IDapperRepository<Banknote>
    {
    }
}
