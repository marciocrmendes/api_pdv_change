using Dapper;
using Entities;
using Infra.Interfaces.IRepository.Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repository.Dapper
{
    public class ProductDapperRepository : DapperRepository<Product>, IProductDapperRepository
    {
        public override IEnumerable<Product> GetAll()
        {
            var sql = @"
                SELECT 
                    * 
                FROM products as p";
            return _connection.Query<Product>(sql);
        }

        public override Product GetById(int id)
        {
            var sql = @"
                SELECT 
                    * 
                FROM products as p
                INNER JOIN sale_product AS sp ON sp.product_id = p.id
                INNER JOIN sales AS s ON s.id = sp.sale_id
                WHERE
                    p.id = @ProductId";
            
            var list = _connection.Query<Product, Sale, Product>(sql
                ,
                map: (product, sale) =>
                {
                    var salesProducts = new SaleProduct()
                    {
                        ProductId = product.Id,
                        Product = product,
                        SaleId = sale.Id,
                        Sale = sale
                    };

                    product.Sales.Add(salesProducts);
                    return product;
                },
                new { ProductId = id }
            );

            return list.AsList().FirstOrDefault();
        }
    }
}
