using System;

namespace CQRSProjectModel.Domain.Interfaces.Repositories.Normalize
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
