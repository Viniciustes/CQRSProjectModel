using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Application.ViewModels;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.ReadOnly;

namespace CQRSProjectModel.Application.Services
{
    public class PessoaAppService : AppService<PessoaViewModel>, IPessoaAppService
    {
        //TODO: Alterar valor null sendo passado no construtor base
        public PessoaAppService(IRepositoryPessoaDenormalizeReadOnly repositoryPessoaDenormalizeReadOnly) : base(null)
        {
        }
    }
}
