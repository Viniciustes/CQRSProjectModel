using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Infrastructure.Data.SQLServer.Context;

namespace CQRSProjectModel.Infrastructure.Data.SQLServer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CQRSProjectModelSQLServerContext context;

        public UnitOfWork(CQRSProjectModelSQLServerContext context)
        {
            this.context = context;
        }

        public bool Commit()
        {
            return context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
