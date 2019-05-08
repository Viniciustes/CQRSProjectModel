using AutoMapper;
using CQRSProjectModel.Application.AutoMapper;
using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Application.Services;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.ReadOnly;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize.WriteOnly;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Context;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Repositories.ReadOnly;
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
            services.AddScoped<IRepositoryPessoaDenormalizeReadOnly, RepositoryPessoaReadOnly>();

            services.AddScoped<IRepositoryPessoaNormalizeWriteOnly, RepositoryPessoa>();

            // 1 - Domain Commands

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
