using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings
{
    public class SaleProductMap : IEntityTypeConfiguration<SaleProduct>
    {
        public void Configure(EntityTypeBuilder<SaleProduct> builder)
        {
            //builder.HasKey(x => x.Id);
            //builder.Property(x => x.Id)
            //    .HasColumnName("id")
            //    .IsRequired();

            builder.HasKey(sp => new { sp.ProductId, sp.SaleId });


            builder.Property(sp => sp.SaleId)
                .HasColumnName("sale_id");
            builder
                .HasOne(sp => sp.Sale)
                .WithMany(s => s.ProductsSold)
                .HasForeignKey(sp => sp.SaleId);

            builder.Property(sp => sp.ProductId)
                .HasColumnName("product_id");
            builder
                .HasOne(sp => sp.Product)
                .WithMany(s => s.Sales)
                .HasForeignKey(sp => sp.ProductId);

            builder.ToTable("sale_product");
        }
    }
}
