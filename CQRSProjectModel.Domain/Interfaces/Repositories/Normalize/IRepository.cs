using System;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Interfaces.Repositories.Normalize
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task Create(TEntity entity);

        void Update(TEntity entity);

        Task Delete(Guid guid);
    }
}
