using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Domain.Models;
using CQRSProjectModel.Infrastructure.Data.SQLServer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CQRSProjectModel.Infrastructure.Data.SQLServer.Repositories
{
    public class RepositoryNormalize<TEntity> : IRepositoryNormalize<TEntity> where TEntity : ModelBase
    {
        private readonly DbSet<TEntity> DbSet;

        protected readonly CQRSProjectModelSQLServerContext context;

        public RepositoryNormalize(CQRSProjectModelSQLServerContext context)
        {
            DbSet = context.Set<TEntity>();
        }

        public async Task Create(TEntity entity)
        {
            await DbSet.AddAsync(entity);
        }

        public async Task Delete(Guid guid)
        {
            var entity = await DbSet.FindAsync(guid);

            if (entity != null)
                DbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return DbSet.AsQueryable().Where(expression);
        }
    }
}
