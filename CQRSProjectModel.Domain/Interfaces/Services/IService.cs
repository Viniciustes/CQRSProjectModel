using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        Task Delete(Guid guid);

        Task Create(TEntity entity);

        void Update(TEntity entity);

        Task<TEntity> GetById(Guid guid);

        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
