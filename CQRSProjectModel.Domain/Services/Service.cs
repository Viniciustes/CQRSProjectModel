using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.ReadOnly;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize.WriteOnly;
using CQRSProjectModel.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Services
{
    class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepositoryNormalizeWriteOnly<TEntity> _repositoryNormalize;

        private readonly IRepositoryDenormalizeReadOnly<TEntity> _repositoryDenormalize;

        public Service(IRepositoryNormalizeWriteOnly<TEntity> repositoryNormalize, IRepositoryDenormalizeReadOnly<TEntity> repositoryDenormalize)
        {
            _repositoryNormalize = repositoryNormalize;

            _repositoryDenormalize = repositoryDenormalize;
        }

        public async Task Create(TEntity entity)
        {
            await _repositoryNormalize.Create(entity);
        }

        public async Task Delete(Guid guid)
        {
            await _repositoryNormalize.Delete(guid);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repositoryDenormalize.GetAllAsync();
        }

        public async Task<TEntity> GetById(Guid guid)
        {
            return await _repositoryDenormalize.GetByIdAsync(guid);
        }

        public void Update(TEntity entity)
        {
            _repositoryNormalize.Update(entity);
        }
    }
}
