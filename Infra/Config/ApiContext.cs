using Entities;
using Infra.Mappings.EFCoreMap;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Config
{
    public class ApiContext : DbContext
    {
        private IConfiguration _configuration;

        public DbSet<Banknote> Banknotes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleBanknote> SaleBanknotes { get; set; }
        public DbSet<SaleProduct> SaleProducts { get; set; }

        public ApiContext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration;
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json configurado
            if (! optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseNpgsql(_configuration.GetConnectionString("PgsqlConnection"))
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            MappingEntities.Init(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
