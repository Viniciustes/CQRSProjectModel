using System;

namespace CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.WriteOnly
{
    public interface IRepositoryDenormalizeWriteOnly<TEntity> where TEntity : class
    {
        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(Guid guid);
    }
}
