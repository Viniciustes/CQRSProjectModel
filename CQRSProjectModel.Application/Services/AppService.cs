using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSProjectModel.Application.Services
{
    public class AppService<TEntity> : IAppService<TEntity> where TEntity : class
    {
        private readonly IService<TEntity> _service;

        public AppService(IService<TEntity> service)
        {
            _service = service;
        }

        public async Task Delete(Guid guid)
        {
            await _service.Delete(guid);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        public async Task<TEntity> GetById(Guid guid)
        {
            return await _service.GetByIdAsync(guid);
        }

        public void Update(TEntity entity)
        {
            _service.Update(entity);
        }
    }
}
