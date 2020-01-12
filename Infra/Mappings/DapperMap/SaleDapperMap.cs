using Dapper.FluentMap.Dommel.Mapping;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings.DapperMap
{
    public class SaleDapperMap : DommelEntityMap<Sale>
    {
        public SaleDapperMap()
        {
            ToTable("sales");
            Map(p => p.Id).IsKey().ToColumn("id");
            Map(p => p.Total).ToColumn("total");
            Map(p => p.Descount).ToColumn("descount");
            Map(p => p.Date).ToColumn("date");
        }
    }
}
