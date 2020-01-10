using Infra.Config;
using Infra.IRepository.Dapper;
using Infra.IRepository.EFCore;
using Infra.Repository.Dapper;
using Infra.Repository.EFCore;
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

            services.AddScoped<IProductDapperRepository, ProductDapperRepository>();
            services.AddScoped<ISaleDapperRepository, SaleDapperRepository>();
            services.AddScoped<IBanknoteDapperRepository, BanknoteDapperRepository>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<IBanknoteRepository, BanknoteRepository>();

        }
    }
}
