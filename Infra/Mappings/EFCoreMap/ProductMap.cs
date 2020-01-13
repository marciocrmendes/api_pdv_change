using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings.EFCoreMap
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Name)
                .HasColumnName("name").IsRequired().HasMaxLength(200);

            builder.Property(x => x.Price)
                .HasColumnName("price").IsRequired()
                .HasColumnType("decimal(15,2)");

            builder.ToTable("products");
        }
    }
}
