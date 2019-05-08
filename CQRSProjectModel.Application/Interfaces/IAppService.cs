﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSProjectModel.Application.Interfaces
{
    public interface IAppService<TEntity> where TEntity : class
    {
        Task Delete(Guid guid);

        Task Create(TEntity entity);

        void Update(TEntity entity);

        Task<TEntity> GetById(Guid guid);

        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
