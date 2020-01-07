using Entities;
using Infra.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infra.Mappings.EFCoreMap
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();

            //builder.Property(cs => cs.CashierId)
            //    .HasColumnName("cashier_id");
            //builder
            //    .HasOne(s => s.Cashier)
            //    .WithMany(cs => cs.Sales)
            //    .HasForeignKey(cs => cs.CashierId);

            builder.Property(x => x.Total)
                .HasColumnName("total")
                .HasColumnType("decimal(15,2)")
                .IsRequired();

            builder.Property(x => x.Descount)
                .HasColumnName("descount")
                .HasColumnType("decimal(15,2)")
                .IsRequired(false);

            builder.Property(x => x.Date)
                .HasColumnName("date")
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .IsRequired();

            builder.ToTable("sales");
        }
    }
}
