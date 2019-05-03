using CQRSProjectModel.Domain.Core.Entities;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize.WriteOnly;
using CQRSProjectModel.Infrastructure.Data.SQLServer.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace CQRSProjectModel.Infrastructure.Data.SQLServer.Repositories
{
    public class Repository<TEntity> : IRepositoryNormalizeWriteOnly<TEntity> where TEntity : Entity
    {
        private readonly DbSet<TEntity> DbSet;

        protected readonly CQRSProjectModelSQLServerContext context;

        public Repository(CQRSProjectModelSQLServerContext context)
        {
            DbSet = context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(Guid guid)
        {
            var entity = DbSet.Find(guid);

            if (entity != null)
                DbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }
    }
}
