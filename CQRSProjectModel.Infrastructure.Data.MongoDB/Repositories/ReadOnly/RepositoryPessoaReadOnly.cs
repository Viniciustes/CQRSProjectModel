using CQRSProjectModel.Domain.Entities;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.ReadOnly;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Context;

namespace CQRSProjectModel.Infrastructure.Data.MongoDB.Repositories.ReadOnly
{
    public class RepositoryPessoaReadOnly : RepositoryReadOnly<Pessoa>, IRepositoryPessoaDenormalizeReadOnly
    {
        private static readonly string nameColection = "Pessoa";

        public RepositoryPessoaReadOnly(CQRSProjectModelMongoDbContext context) : base(context, nameColection)
        {
        }
    }
}
