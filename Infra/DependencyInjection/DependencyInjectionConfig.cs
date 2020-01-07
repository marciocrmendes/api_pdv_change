using Infra.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

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
            //services.AddScoped<IAutorEFRepository, AutorEFRepository>();
            //services.AddScoped<ILivroEFRepository, LivroEFRepository>();
            //services.AddScoped<IAutorDapperRepository, AutorDapperRepository>();
            //services.AddScoped<ILivroDapperRepository, LivroDapperRepository>();
        }
    }
}
