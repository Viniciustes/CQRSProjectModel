using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Domain.Entities;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.ReadOnly;

namespace CQRSProjectModel.Application.Services
{
    public class PessoaAppService : AppService<Pessoa>, IPessoaAppService
    {
        public PessoaAppService(IRepositoryPessoaDenormalizeReadOnly repositoryPessoaDenormalizeReadOnly) : base(repositoryPessoaDenormalizeReadOnly)
        {
        }
    }
}
