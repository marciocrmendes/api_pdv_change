using Dapper;
using Entities;
using Infra.Interfaces.IRepository.Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.Dapper
{
    public class BanknoteDapperRepository : DapperRepository<Banknote>, IBanknoteDapperRepository
    {
        public override IEnumerable<Banknote> GetAll()
        {
            var sql = @"
                SELECT 
                    * 
                FROM banknotes as b";
            
            using (var conn = _connection)
            {
                return conn.Query<Banknote>(sql);
            }
        }

        public override Banknote GetById(int id)
        {
            var sql = @"
                SELECT 
                    * 
                FROM banknotes as b
                    b.id = @BanknoteId";

            var banknote = new Banknote();
            using (var conn = _connection)
            {
                conn.Query<Banknote>(sql, new { BanknoteId = id });
            }
            return banknote;
        }
    }
}
