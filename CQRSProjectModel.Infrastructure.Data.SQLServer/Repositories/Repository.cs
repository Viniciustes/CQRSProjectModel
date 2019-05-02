using CQRSProjectModel.Domain.Interfaces.Repositories;
using CQRSProjectModel.Infrastructure.Data.SQLServer.Context;
using Microsoft.EntityFrameworkCore;

namespace CQRSProjectModel.Infrastructure.Data.SQLServer.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
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

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }
    }
}
