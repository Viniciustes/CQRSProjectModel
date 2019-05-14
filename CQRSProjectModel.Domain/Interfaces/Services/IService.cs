using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        Task Delete(Guid guid);

        void Update(TEntity entity);

        IQueryable<TEntity> FindNormalize(Expression<Func<TEntity, bool>> expression);

        IQueryable<TEntity> FindDenormalize(Expression<Func<TEntity, bool>> expression);

        Task<TEntity> GetByIdAsync(Guid guid);

        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
