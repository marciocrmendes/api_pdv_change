using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Seed
{
    public static class SeedingEntities
    {
        /// <summary>
        /// Inicializa o seeding dos dados
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void Init(ModelBuilder modelBuilder)
        {
            new SaleSeed(modelBuilder);
            new ProductSeed(modelBuilder);
            new SaleProductSeed(modelBuilder);
        }
    }
}
