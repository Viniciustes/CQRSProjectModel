using AutoMapper;
using CQRSProjectModel.Application.AutoMapper;
using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Application.Services;
using CQRSProjectModel.Domain.Interfaces.Mediators;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Domain.Interfaces.Services;
using CQRSProjectModel.Domain.Notifications;
using CQRSProjectModel.Domain.Requests.Events.Pessoa;
using CQRSProjectModel.Domain.Requests.Pessoa;
using CQRSProjectModel.Domain.RequestsHandlers;
using CQRSProjectModel.Domain.RequestsHandlers.Events;
using CQRSProjectModel.Domain.Services;
using CQRSProjectModel.Infrastructure.CrossCutting.Mediator.Mediators;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Context;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Repositories;
using CQRSProjectModel.Infrastructure.Data.SQLServer.Context;
using CQRSProjectModel.Infrastructure.Data.SQLServer.Repositories;
using CQRSProjectModel.Infrastructure.Data.SQLServer.UnitOfWork;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CQRSProjectModel.Infrastructure.CrossCutting.IoC.DependencyInjections
{
    public class InjectorBootstrapper
    {
        public static void ConfigureServiceCollection(IServiceCollection services)
        {
            // 1 - Domain
            services.AddScoped<IServicePessoa, ServicePessoa>();

            services.AddScoped<IRepositoryNormalizePessoa, RepositoryNormalizePessoa>();
            services.AddScoped<IRepositoryDenormalizePessoa, RepositoryDenormalizePessoa>();

            services.AddScoped<IMediatorHandler, MediatorHandler>();

            //Todo: Verificar diferenças INotificationHandler e IRequestHandler
            // 1 - Domain Request
            services.AddScoped<INotificationHandler<Notification>, NotificationRequestHandler>();

            services.AddScoped<IRequestHandler<CreateRequestPessoa>, PessoaRequestHandler>();

            services.AddScoped<INotificationHandler<CreateRequestEventPessoa>, RequestHandlerEventPessoa>();

            // 2 - Application
            services.AddScoped<IPessoaAppService, PessoaAppService>();

            // 3 Infrastructure - Data
            services.AddScoped<CQRSProjectModelMongoDbContext>();
            services.AddScoped<CQRSProjectModelSQLServerContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // 3 Infrastructure - CrossCutting -- MediatR
            var assemblyForMediatR = AppDomain.CurrentDomain.Load("CQRSProjectModel.Domain");
            services.AddMediatR(assemblyForMediatR);

            // 3 Infrastructure - CrossCutting -- AutoMapper
            var assemblyForAutoMapper = AppDomain.CurrentDomain.Load("CQRSProjectModel.Application");
            services.AddAutoMapper(assemblyForAutoMapper);
            AutoMapperConfig.RegisterMappings();
        }

        public static void ConfigureApplicationBuilder(IApplicationBuilder app)
        {
        }
    }
}
