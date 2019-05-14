using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Domain.Models;
using CQRSProjectModel.Infrastructure.Data.SQLServer.Context;

namespace CQRSProjectModel.Infrastructure.Data.SQLServer.Repositories
{
    public class RepositoryNormalizePessoa : RepositoryNormalize<Pessoa>, IRepositoryNormalizePessoa
    {
        public RepositoryNormalizePessoa(CQRSProjectModelSQLServerContext context) : base(context)
        {
        }
    }
}
