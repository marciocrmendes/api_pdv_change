using Dapper;
using Entities;
using Infra.IRepository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.Dapper
{
    public class ProductDapperRepository : DapperRepository<Product>, IProductRepository
    {
        public ProductDapperRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public override IEnumerable<Product> GetAll()
        {
            return _connection.Query<Product, Sale, Product>(
                @"
                SELECT 
                    * 
                FROM product as p
                INNER JOIN sale as s ON",
                map: (product, sale) =>
                {
                    //product.Sales = sale;
                    return product;
                });
        }

        public override Product GetById(int id)
        {
            return base.GetById(id);
        }
    }
}
