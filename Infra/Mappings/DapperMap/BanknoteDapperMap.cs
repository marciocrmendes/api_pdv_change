using Dapper.FluentMap.Dommel.Mapping;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings.DapperMap
{
    public class BanknoteDapperMap : DommelEntityMap<Banknote>
    {
        public BanknoteDapperMap()
        {
            ToTable("banknote");
            Map(p => p.Id).IsKey().ToColumn("id");
            Map(p => p.Type).ToColumn("type");
            Map(p => p.Value).ToColumn("value");
        }
    }
}
