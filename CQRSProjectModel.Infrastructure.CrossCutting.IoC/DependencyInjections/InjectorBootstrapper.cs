using CQRSProjectModel.Infrastructure.Data.MongoDB.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSProjectModel.Infrastructure.CrossCutting.IoC.DependencyInjections
{
    public class InjectorBootstrapper
    {
        public static void ConfigureServiceCollection(IServiceCollection services)
        {
            // 2 - Application
            //services.AddScoped<IAnimalAppService, AnimalAppService>();

            // 3 Infrastructure - Data
            services.AddScoped<CQRSProjectModelMongoDbContext>();
            services.AddScoped<CQRSProjectModelSQLServerContext>();
        }

        public static void ConfigureApplicationBuilder(IApplicationBuilder app)
        {

        }
    }
}
