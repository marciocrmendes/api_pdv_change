﻿// <auto-generated />
using System;
using Infra.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infra.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Entities.Banknote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<short>("Type")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("type")
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)0);

                    b.Property<int>("Value")
                        .HasColumnName("value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("banknote");
                });

            modelBuilder.Entity("Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("Price")
                        .HasColumnName("price")
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Manteiga",
                            Price = 5m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Óleo de cozinha",
                            Price = 9.20m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Coca cola 2L",
                            Price = 10m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Chamito",
                            Price = 4.99m
                        });
                });

            modelBuilder.Entity("Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("date")
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<decimal?>("Descount")
                        .HasColumnName("descount")
                        .HasColumnType("decimal(15,2)");

                    b.Property<decimal>("Total")
                        .HasColumnName("total")
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.ToTable("sales");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2020, 1, 7, 0, 47, 43, 584, DateTimeKind.Local).AddTicks(4954),
                            Descount = 0m,
                            Total = 50m
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2020, 1, 7, 0, 47, 43, 584, DateTimeKind.Local).AddTicks(9521),
                            Descount = 0m,
                            Total = 10m
                        });
                });

            modelBuilder.Entity("Entities.SaleBanknote", b =>
                {
                    b.Property<int>("BanknoteId")
                        .HasColumnName("banknote_id")
                        .HasColumnType("integer");

                    b.Property<int>("SaleId")
                        .HasColumnName("sale_id")
                        .HasColumnType("integer");

                    b.HasKey("BanknoteId", "SaleId");

                    b.HasIndex("SaleId");

                    b.ToTable("sale_banknote");
                });

            modelBuilder.Entity("Entities.SaleProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnName("product_id")
                        .HasColumnType("integer");

                    b.Property<int>("SaleId")
                        .HasColumnName("sale_id")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("quantity")
                        .HasColumnType("integer")
                        .HasDefaultValue(1);

                    b.HasKey("ProductId", "SaleId");

                    b.HasIndex("Quantity");

                    b.HasIndex("SaleId");

                    b.ToTable("sale_product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            SaleId = 1,
                            Quantity = 3
                        },
                        new
                        {
                            ProductId = 2,
                            SaleId = 1,
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("Entities.SaleBanknote", b =>
                {
                    b.HasOne("Entities.Banknote", "Banknote")
                        .WithMany("Sales")
                        .HasForeignKey("BanknoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Sale", "Sale")
                        .WithMany("Banknotes")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.SaleProduct", b =>
                {
                    b.HasOne("Entities.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Sale", "Sale")
                        .WithMany("ProductsSold")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}