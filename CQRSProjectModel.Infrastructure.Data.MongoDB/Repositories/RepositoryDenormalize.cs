using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize;
using CQRSProjectModel.Domain.Models;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Context;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CQRSProjectModel.Infrastructure.Data.MongoDB.Repositories
{
    public class RepositoryDenormalize<TEntity> : IRepositoryDenormalize<TEntity> where TEntity : ModelBase
    {
        protected readonly IMongoCollection<TEntity> mongoCollection;

        public RepositoryDenormalize(CQRSProjectModelMongoDbContext context, string nameColection)
        {
            mongoCollection = context.MongoDatabase.GetCollection<TEntity>(nameColection);
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

        public void Create(TEntity entity)
        {
            mongoCollection.InsertOne(entity);
        }

        public void Delete(Guid guid)
        {
            mongoCollection.DeleteOne(x => x.Id == guid);
        }

        public void Update(TEntity entity)
        {
            mongoCollection.ReplaceOne(x => x.Id == entity.Id, entity);
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return mongoCollection.AsQueryable().Where(expression);
        }
    }
}
