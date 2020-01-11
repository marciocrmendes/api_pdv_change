using Infra.Config;
using Infra.Interfaces.IRepository.Dapper;
using Infra.Interfaces.IRepository.EFCore;
using Infra.Interfaces.IServices;
using Infra.Repository.Dapper;
using Infra.Repository.EFCore;
using Infra.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.DependencyInjection
{
    public static class DependencyInjectionConfig
    {
        /// <summary>
        /// Inicializa a injeção de dependências da aplicação
        /// </summary>
        /// <param name="services"></param>
        public static void InitServices(this IServiceCollection services)
        {
            services.AddScoped<DbContext, ApiContext>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<IBanknoteRepository, BanknoteRepository>();

            services.AddScoped<IProductDapperRepository, ProductDapperRepository>();
            services.AddScoped<ISaleDapperRepository, SaleDapperRepository>();
            services.AddScoped<IBanknoteDapperRepository, BanknoteDapperRepository>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISaleService, SaleService>();
            services.AddScoped<IBanknoteService, BanknoteService>();
        }
    }
}
