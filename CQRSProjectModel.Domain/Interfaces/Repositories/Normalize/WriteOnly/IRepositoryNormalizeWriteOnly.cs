using System;

namespace CQRSProjectModel.Domain.Interfaces.Repositories.Normalize.WriteOnly
{
    public interface IRepositoryNormalizeWriteOnly<TEntity> where TEntity : class
    {
        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(Guid guid);
    }
}
