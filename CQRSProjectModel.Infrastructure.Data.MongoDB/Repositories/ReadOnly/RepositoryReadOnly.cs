using CQRSProjectModel.Domain.Core.Entities;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.ReadOnly;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Context;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CQRSProjectModel.Infrastructure.Data.MongoDB.Repositories.ReadOnly
{
    public class RepositoryReadOnly<TEntity> : IRepositoryDenormalizeReadOnly<TEntity> where TEntity : Entity
    {
        protected readonly IMongoCollection<TEntity> mongoCollection;

        public RepositoryReadOnly(CQRSProjectModelMongoDbContext context, string nameColection)
        {
            mongoCollection = context.mongoDatabase.GetCollection<TEntity>(nameColection);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return expression == null ? GetAll() : GetAll().Where(expression);
        }

        public async Task<IList<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression)
        {
            return expression == null ? await GetAllAsync() : mongoCollection.AsQueryable().Where(expression).ToList();
        }

        public IQueryable<TEntity> GetAll()
        {
            return mongoCollection.AsQueryable();
        }

        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await mongoCollection.AsQueryable().ToListAsync();
        }

        public TEntity GetById(Guid guid)
        {
            return mongoCollection.Find(x => x.Id == guid).FirstOrDefault();
        }

        public async Task<TEntity> GetByIdAsync(Guid guid)
        {
            return await mongoCollection.Find(x => x.Id == guid).FirstOrDefaultAsync();
        }
    }
}
