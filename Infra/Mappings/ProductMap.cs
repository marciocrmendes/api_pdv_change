using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id").IsRequired();

            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Name)
                .HasColumnName("name").IsRequired().HasMaxLength(200);

            builder.HasIndex(x => x.Price).IsUnique();
            builder.Property(x => x.Price)
                .HasColumnName("total").IsRequired()
                .HasColumnType("decimal(15,2)");

            builder.HasIndex(x => x.Descount).IsUnique();
            builder.Property(x => x.Descount)
                .HasColumnName("total")
                .HasDefaultValue(0.00)
                .HasColumnType("decimal(15,2)");

            builder.ToTable("products");
        }
    }
}
