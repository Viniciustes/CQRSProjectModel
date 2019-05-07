using CQRSProjectModel.Domain.Entities;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize.WriteOnly;
using CQRSProjectModel.Infrastructure.Data.SQLServer.Context;

namespace CQRSProjectModel.Infrastructure.Data.SQLServer.Repositories
{
    public class RepositoryPessoa : Repository<Pessoa>, IRepositoryPessoaNormalizeWriteOnly
    {
        public RepositoryPessoa(CQRSProjectModelSQLServerContext context) : base(context)
        {
        }
    }
}
