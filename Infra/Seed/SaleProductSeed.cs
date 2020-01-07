using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Seed
{
    public class SaleSeed
    {
        public SaleSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>().HasData(
               new Sale
               {
                   Id = 1,
                   Total = 50,
                   Date = DateTime.Now,
                   Descount = 0,
               },
               new Sale
               {
                   Id = 2,
                   Total = 10,
                   Date = DateTime.Now,
                   Descount = 0,
               }
            );
        }
    }
}
