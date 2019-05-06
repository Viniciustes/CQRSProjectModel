using AutoMapper;
using CQRSProjectModel.API;
using CQRSProjectModel.Application.AutoMapper;
using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Application.Services;
using CQRSProjectModel.Domain.Commands.Pessoa.Normalize;
using CQRSProjectModel.Domain.CommandsHandlers.Normalize;
using CQRSProjectModel.Domain.Core.Mediators.Normalize;
using CQRSProjectModel.Domain.Core.Notifications;
using CQRSProjectModel.Domain.Events.Pessoa;
using CQRSProjectModel.Domain.EventsHandlers;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.ReadOnly;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Infrastructure.CrossCutting.Mediator.Mediators;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Context;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Repositories.ReadOnly;
using CQRSProjectModel.Infrastructure.Data.SQLServer.Context;
using CQRSProjectModel.Infrastructure.Data.SQLServer.UnitOfWork;
using MediatR;
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

            // 1 - Domain Commands
            services.AddScoped<IRequestHandler<CreatePessoaCommandNormalize>, PessoaCommandHandlerNormalize>();

            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            services.AddScoped<INotificationHandler<PessoaCreatedEvent>, PessoaEventHandler>();

            // 2 - Application
            services.AddScoped<IPessoaAppService, PessoaAppService>();

            // 3 Infrastructure - Data
            services.AddScoped<CQRSProjectModelMongoDbContext>();
            services.AddScoped<CQRSProjectModelSQLServerContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // 3 Infrastructure - CrossCutting
            services.AddMediatR(typeof(Startup));
            services.AddScoped<IMediatorHandlerNormalize, MediatorHandlerNormalize>();
            services.AddAutoMapper();
            AutoMapperConfig.RegisterMappings();
        }

        public static void ConfigureApplicationBuilder(IApplicationBuilder app)
        {
        }
    }
}
