using CQRSProjectModel.Application.ViewModels;
using CQRSProjectModel.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSProjectModel.Application.Interfaces
{
    public interface IPessoaAppService : IAppService<PessoaViewModel>
    {
        Task Create(PessoaViewModel pessoaViewModel);

    }
}
