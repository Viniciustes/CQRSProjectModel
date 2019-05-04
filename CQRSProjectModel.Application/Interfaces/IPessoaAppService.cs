using CQRSProjectModel.Application.ViewModels;
using CQRSProjectModel.Domain.Entities;
using System.Threading.Tasks;

namespace CQRSProjectModel.Application.Interfaces
{
    public interface IPessoaAppService : IAppService<Pessoa>
    {
        Task Create(PessoaViewModel pessoaViewModel);
    }
}
