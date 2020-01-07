using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Seed
{
    public class SaleProductSeed
    {
        public SaleProductSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SaleProduct>().HasData(
               new SaleProduct
               {
                   SaleId = 1,
                   ProductId = 1,
                   Quantity = 3
               },
               new SaleProduct
               {
                   SaleId = 1,
                   ProductId = 2,
                   Quantity = 3
               }
            );
        }
    }
}
