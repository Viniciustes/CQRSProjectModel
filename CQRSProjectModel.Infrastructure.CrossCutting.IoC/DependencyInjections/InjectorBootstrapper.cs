using AutoMapper;
using CQRSProjectModel.Application.AutoMapper;
using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Application.Services;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Domain.Requests.Notification;
using CQRSProjectModel.Domain.Requests.Pessoa.Normalize;
using CQRSProjectModel.Domain.RequestsHandlers;
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
            services.AddScoped<IRepositoryPessoa, RepositoryPessoa>();

            services.AddScoped<IRepositoryDenormalizePessoa, RepositoryDenormalizePessoa>();

            //Todo: Verificar diferenças INotificationHandler e IRequestHandler
            // 1 - Domain Request
            services.AddScoped<INotificationHandler<NotificationRequest>, NotificationRequestHandler>();

            //services.AddScoped<INotificationHandler<CreatePessoaRequestNormalize>, PessoaRequestHandler>();

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
