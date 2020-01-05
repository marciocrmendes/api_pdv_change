using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings
{
    public class CashierMap : IEntityTypeConfiguration<Cashier>
    {
        public void Configure(EntityTypeBuilder<Cashier> builder)
        {
            //TODO incompleto

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id").IsRequired();

            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Name)
                .HasColumnName("name").IsRequired().HasMaxLength(200);

            builder.HasIndex(x => x.Total).IsUnique();
            builder.Property(x => x.Total)
                .HasColumnName("total").IsRequired()
                .HasColumnType("decimal(15,2)");

            builder.ToTable("cashier");
        }
    }
}
