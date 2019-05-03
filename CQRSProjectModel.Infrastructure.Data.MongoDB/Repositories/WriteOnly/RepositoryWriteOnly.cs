﻿using CQRSProjectModel.Domain.Core.Entities;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.WriteOnly;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Context;
using MongoDB.Driver;
using System;

namespace CQRSProjectModel.Infrastructure.Data.MongoDB.Repositories.WriteOnly
{
    class RepositoryWriteOnly<TEntity> : IRepositoryDenormalizeWriteOnly<TEntity> where TEntity : Entity
    {
        protected readonly IMongoCollection<TEntity> mongoCollection;

        public RepositoryWriteOnly(CQRSProjectModelMongoDbContext context, string nameColection)
        {
            mongoCollection = context.mongoDatabase.GetCollection<TEntity>(nameColection);
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
    }
}
