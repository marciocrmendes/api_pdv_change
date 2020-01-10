using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Seed
{
    public class BanknoteSeed
    {
        public BanknoteSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banknote>().HasData(
               new Banknote
               {
                   Id = 1,
                   Value = 0.01m,
                   Type = Entities.Enum.BankNoteEnum.Coin,
               },
               new Banknote
               {
                   Id = 2,
                   Value = 0.05m,
                   Type = Entities.Enum.BankNoteEnum.Coin,
               },
               new Banknote
               {
                   Id = 3,
                   Value = 0.10m,
                   Type = Entities.Enum.BankNoteEnum.Coin,
               },
               new Banknote
               {
                   Id = 4,
                   Value = 0.50m,
                   Type = Entities.Enum.BankNoteEnum.Coin,
               },
               new Banknote
               {
                   Id = 5,
                   Value = 10,
                   Type = Entities.Enum.BankNoteEnum.Note,
               },
               new Banknote
               {
                   Id = 6,
                   Value = 20,
                   Type = Entities.Enum.BankNoteEnum.Note,
               },
               new Banknote
               {
                   Id = 7,
                   Value = 50,
                   Type = Entities.Enum.BankNoteEnum.Note,
               },
               new Banknote
               {
                   Id = 8,
                   Value = 100,
                   Type = Entities.Enum.BankNoteEnum.Note,
               }
            );
        }
    }
}
