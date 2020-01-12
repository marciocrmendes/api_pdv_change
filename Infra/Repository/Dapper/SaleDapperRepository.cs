using Dapper;
using Entities;
using Infra.Interfaces.IRepository.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repository.Dapper
{
    public class SaleDapperRepository : DapperRepository<Sale>, ISaleDapperRepository
    {
        public override IEnumerable<Sale> GetAll()
        {
            var sql = @"
                SELECT 
                    * 
                FROM sales as s
                INNER JOIN sale_product AS sp ON sp.sale_id = s.id
                INNER JOIN products AS p ON p.id = sp.product_id";

            var sales = new List<Sale>();

            using (var conn = _connection)
            {
                conn.Query<Sale, Product, Sale>(sql
                    ,
                    map: (s, p) =>
                    {
                        var salesProducts = new SaleProduct()
                        {
                            ProductId = p.Id,
                            Product = p,
                            SaleId = s.Id,
                            Sale = s
                        };

                        var finder = sales.Find(x => x.Id == s.Id);
                        if (finder != null)
                        {
                            finder.ProductsSold.Add(salesProducts);
                        }
                        else
                        {
                            s.ProductsSold.Add(salesProducts);

                            sales.Add(s);
                        }

                        return s;
                    }
                );
            }
            return sales;
        }

        public override Sale GetById(int id)
        {
            var sql = @"
                SELECT 
                    * 
                FROM sales as s
                INNER JOIN sale_product AS sp ON sp.sale_id = s.id
                INNER JOIN sale_banknote as sb ON sb.sale_id = s.id
                INNER JOIN products AS p ON p.id = sp.product_id
                INNER JOIN banknotes AS b ON b.id = sb.banknote_id
                WHERE
                    s.id = @SaleId";

            var s = new Sale();
            using (var conn = _connection)
            {
                conn.Query<Sale, Product, Banknote, Sale>(sql
                    ,
                    map: (sale, product, banknote) =>
                    {
                        var salesProducts = new SaleProduct()
                        {
                            ProductId = product.Id,
                            Product = product,
                            SaleId = sale.Id,
                            Sale = sale
                        };

                        var salesBanknotes = new SaleBanknote()
                        {
                            SaleId = sale.Id,
                            Sale = sale,
                            BanknoteId = banknote.Id,
                            Banknote = banknote
                        };

                        s.ProductsSold.Add(salesProducts);
                        s.Banknotes.Add(salesBanknotes);
                        return sale;
                    },
                    new { SaleId = id }
                );
            }
            return s;
        }
    }
}
