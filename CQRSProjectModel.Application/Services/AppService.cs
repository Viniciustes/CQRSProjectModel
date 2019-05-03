using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.ReadOnly;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSProjectModel.Application.Services
{
    public class AppService<TEntity> : IAppService<TEntity> where TEntity : class
    {
        private readonly IRepositoryDenormalizeReadOnly<TEntity> repositoryDenormalizeReadOnly;

        public AppService(IRepositoryDenormalizeReadOnly<TEntity> repositoryDenormalizeReadOnly)
        {
            this.repositoryDenormalizeReadOnly = repositoryDenormalizeReadOnly;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await repositoryDenormalizeReadOnly.GetAllAsync();
        }
    }
}
