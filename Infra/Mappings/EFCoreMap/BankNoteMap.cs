using Entities;
using Entities.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings.EFCoreMap
{
    public class BankNoteMap : IEntityTypeConfiguration<Banknote>
    {
        public void Configure(EntityTypeBuilder<Banknote> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id").IsRequired();

            builder.Property(x => x.Value)
                .HasColumnName("value").IsRequired();

            builder.Property(x => x.Type)
                .HasConversion(
                    x => (short)x,
                    x => (BankNoteEnum)Enum.Parse(typeof(BankNoteEnum), x.ToString()))
                .HasColumnName("type")
                .HasDefaultValue(BankNoteEnum.Note)
                .IsRequired();
            
            builder.ToTable("banknote");
        }
    }
}
