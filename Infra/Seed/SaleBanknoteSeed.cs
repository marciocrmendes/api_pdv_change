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
                      BanknoteId = 6
                  },
                  new SaleBanknote
                  {
                      SaleId = 1,
                      BanknoteId = 6
                  },
                  new SaleBanknote
                  {
                      SaleId = 1,
                      BanknoteId = 4
                  },
                  new SaleBanknote
                  {
                      SaleId = 1,
                      BanknoteId = 4
                  },
                  new SaleBanknote
                  {
                      SaleId = 1,
                      BanknoteId = 4
                  },
                  new SaleBanknote
                  {
                      SaleId = 1,
                      BanknoteId = 4
                  },
                  new SaleBanknote
                  {
                      SaleId = 1,
                      BanknoteId = 4
                  },
                  new SaleBanknote
                  {
                      SaleId = 1,
                      BanknoteId = 3
                  }
               );
        }
    }
}