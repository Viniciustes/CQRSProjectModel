﻿namespace CQRSProjectModel.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}