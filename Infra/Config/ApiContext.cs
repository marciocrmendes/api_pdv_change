using Entities;
using Infra.Mappings.EFCoreMap;
using Infra.Seed;
using Microsoft.EntityFrameworkCore;

namespace Infra.Config
{
    public class ApiContext : DbContext
    {
        public DbSet<Banknote> Banknotes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleBanknote> SaleBanknotes { get; set; }
        public DbSet<SaleProduct> SaleProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json configurado
            if (! optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseNpgsql(AppConfigurationMannager.GetConnectionString("PgsqlConnection"))
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            MappingEntities.Init(modelBuilder);
            SeedingEntities.Init(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
