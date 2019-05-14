using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Interfaces.Repositories.Normalize
{
    public interface IRepositoryNormalize<TEntity> where TEntity : class
    {
        Task Create(TEntity entity);

        void Update(TEntity entity);

        Task Delete(Guid guid);

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
    }
}
