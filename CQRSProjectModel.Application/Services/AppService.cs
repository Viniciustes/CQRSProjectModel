using AutoMapper;
using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.ReadOnly;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSProjectModel.Application.Services
{
    public class AppService<TEntity> : IAppService<TEntity> where TEntity : class
    {
        private readonly IMapper mapper;
        private readonly IRepositoryDenormalizeReadOnly<TEntity> repositoryDenormalizeReadOnly;

        public AppService(IMapper mapper, IRepositoryDenormalizeReadOnly<TEntity> repositoryDenormalizeReadOnly)
        {
            this.mapper = mapper;
            this.repositoryDenormalizeReadOnly = repositoryDenormalizeReadOnly;
        }

        public async Task Create(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await repositoryDenormalizeReadOnly.GetAllAsync();
        }
    }
}
