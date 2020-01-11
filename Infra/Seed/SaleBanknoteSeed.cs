using Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Seed
{
    public class SaleBanknoteSeed
    {
        public SaleBanknoteSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SaleBanknote>().HasData(
                  new SaleBanknote
                  {
                      SaleId = 1,
                      BanknoteId = 6,
                      Quantity = 2
                  },
                  new SaleBanknote
                  {
                      SaleId = 1,
                      BanknoteId = 4,
                      Quantity = 5
                  },
                  new SaleBanknote
                  {
                      SaleId = 1,
                      BanknoteId = 3,
                      Quantity = 1
                  }
               );
        }
    }
}