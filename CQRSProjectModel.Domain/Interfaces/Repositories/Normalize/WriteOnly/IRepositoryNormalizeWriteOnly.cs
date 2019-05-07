using System;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Interfaces.Repositories.Normalize.WriteOnly
{
    public interface IRepositoryNormalizeWriteOnly<TEntity> where TEntity : class
    {
        Task Create(TEntity entity);

        void Update(TEntity entity);

        Task Delete(Guid guid);
    }
}
