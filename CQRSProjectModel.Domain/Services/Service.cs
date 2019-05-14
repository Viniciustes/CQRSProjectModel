using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepositoryNormalize<TEntity> _repositoryNormalize;
        private readonly IRepositoryDenormalize<TEntity> _repositoryDenormalize;

        public Service(IRepositoryNormalize<TEntity> repositoryNormalize, IRepositoryDenormalize<TEntity> repositoryDenormalize)
        {
            _repositoryNormalize = repositoryNormalize;
            _repositoryDenormalize = repositoryDenormalize;
        }

        public async Task Delete(Guid guid)
        {
            await _repositoryNormalize.Delete(guid);
        }

        public IQueryable<TEntity> FindNormalize(Expression<Func<TEntity, bool>> expression)
        {
            return _repositoryNormalize.Find(expression);
        }

        public IQueryable<TEntity> FindDenormalize(Expression<Func<TEntity, bool>> expression)
        {
            return _repositoryDenormalize.Find(expression);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repositoryDenormalize.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid guid)
        {
            return await _repositoryDenormalize.GetByIdAsync(guid);
        }

        public void Update(TEntity entity)
        {
            _repositoryNormalize.Update(entity);
        }
    }
}
