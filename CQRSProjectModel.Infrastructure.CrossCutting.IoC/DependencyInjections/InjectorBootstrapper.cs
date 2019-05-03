using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Application.Services;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.ReadOnly;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Context;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Repositories.ReadOnly;
using CQRSProjectModel.Infrastructure.Data.SQLServer.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSProjectModel.Infrastructure.CrossCutting.IoC.DependencyInjections
{
    public class InjectorBootstrapper
    {
        public static void ConfigureServiceCollection(IServiceCollection services)
        {
            // 1 - Domain
            services.AddScoped<IRepositoryPessoaDenormalizeReadOnly, RepositoryPessoaReadOnly>();

            // 2 - Application
            services.AddScoped<IPessoaAppService, PessoaAppService>();

            // 3 Infrastructure - Data
            services.AddScoped<CQRSProjectModelMongoDbContext>();
            services.AddScoped<CQRSProjectModelSQLServerContext>();
        }

        public static void ConfigureApplicationBuilder(IApplicationBuilder app)
        {

        }
    }
}
