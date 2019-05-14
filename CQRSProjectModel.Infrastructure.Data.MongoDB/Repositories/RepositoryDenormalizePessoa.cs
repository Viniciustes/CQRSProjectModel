using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize;
using CQRSProjectModel.Domain.Models;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Context;

namespace CQRSProjectModel.Infrastructure.Data.MongoDB.Repositories
{
    public class RepositoryDenormalizePessoa : RepositoryDenormalize<Pessoa>, IRepositoryDenormalizePessoa
    {
        private static readonly string nameColection = "Pessoa";

        public RepositoryDenormalizePessoa(CQRSProjectModelMongoDbContext context) : base(context, nameColection)
        {
        }
    }
}
