using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize
{
    public interface IRepositoryDenormalize<TEntity> where TEntity : class
    {
        TEntity GetById(Guid guid);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression);

        Task<TEntity> GetByIdAsync(Guid guid);

        Task<IList<TEntity>> GetAllAsync();

        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(Guid guid);
    }
}
