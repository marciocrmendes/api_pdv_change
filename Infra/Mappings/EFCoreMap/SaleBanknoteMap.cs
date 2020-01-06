using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings.EFCoreMap
{
    public class SaleBanknoteMap : IEntityTypeConfiguration<SaleBanknote>
    {
        public void Configure(EntityTypeBuilder<SaleBanknote> builder)
        {
            builder.HasKey(sp => new { sp.BanknoteId, sp.SaleId });

            builder.Property(sp => sp.SaleId)
                .HasColumnName("sale_id");
            builder
                .HasOne(sp => sp.Sale)
                .WithMany(s => s.Banknotes)
                .HasForeignKey(sp => sp.SaleId);

            builder.Property(sp => sp.BanknoteId)
                .HasColumnName("banknote_id");
            builder
                .HasOne(sp => sp.Banknote)
                .WithMany(s => s.Sales)
                .HasForeignKey(sp => sp.BanknoteId);

            builder.ToTable("sale_banknote");
        }
    }
}
