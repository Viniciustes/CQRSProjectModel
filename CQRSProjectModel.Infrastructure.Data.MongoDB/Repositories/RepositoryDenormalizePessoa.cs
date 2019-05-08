using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize;
using CQRSProjectModel.Domain.Models;
using CQRSProjectModel.Infrastructure.Data.MongoDB.Context;

namespace CQRSProjectModel.Infrastructure.Data.MongoDB.Repositories
{
    public class RepositoryDenormalizePessoa : RepositoryDenormalize<Pessoa>, IRepositoryDenormalizePessoa
    {
        public RepositoryDenormalizePessoa(CQRSProjectModelMongoDbContext context, string nameColection) : base(context, nameColection)
        {
        }
    }
}
