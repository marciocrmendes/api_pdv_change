using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Seed
{
    public class ProductSeed
    {
        public ProductSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   Name = "Manteiga",
                   Price = 5,
               },
               new Product
               {
                   Id = 2,
                   Name = "Óleo de cozinha",
                   Price = 9.20m,
               },
               new Product
               {
                   Id = 3,
                   Name = "Coca cola 2L",
                   Price = 10,
               },
               new Product
               {
                   Id = 4,
                   Name = "Chamito",
                   Price = 4.99m,
               });
        }
    }
}
