using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Domain.Models;
using CQRSProjectModel.Infrastructure.Data.SQLServer.Context;

namespace CQRSProjectModel.Infrastructure.Data.SQLServer.Repositories
{
    public class RepositoryPessoa : Repository<Pessoa>, IRepositoryPessoa
    {
        public RepositoryPessoa(CQRSProjectModelSQLServerContext context) : base(context)
        {
        }
    }
}
