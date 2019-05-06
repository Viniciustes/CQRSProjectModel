using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSProjectModel.Application.Interfaces
{
    public interface IAppService<TEntity> where TEntity : class
    {
        Task Create(TEntity entity);

        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
