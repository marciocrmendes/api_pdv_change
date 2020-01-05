using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infra.Mappings
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.HasIndex(x => x.Total);
            builder.Property(x => x.Total)
                .HasColumnName("total")
                .HasColumnType("decimal(15,2)")
                .IsRequired();

            builder.HasIndex(x => x.Descount);
            builder.Property(x => x.Descount)
                .HasColumnName("descount")
                .HasDefaultValue(0.00)
                .HasColumnType("decimal(15,2)");

            builder.HasIndex(x => x.Date);
            builder.Property(x => x.Date)
                .HasColumnName("date")
                .HasDefaultValue("now()")
                .IsRequired();

            builder.ToTable("sales");
        }
    }
}
