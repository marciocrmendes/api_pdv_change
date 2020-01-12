using Entities;
using Dapper.FluentMap.Dommel.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings.DapperMap
{
    public class ProductDapperMap : DommelEntityMap<Product>
    {
        public ProductDapperMap()
        {
            ToTable("products");
            Map(p => p.Id).IsKey().ToColumn("id");
            Map(p => p.Name).ToColumn("name");
            Map(p => p.Price).ToColumn("price");
        }
    }
}
