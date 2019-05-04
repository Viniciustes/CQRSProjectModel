using System.Threading.Tasks;
using AutoMapper;
using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Application.ViewModels;
using CQRSProjectModel.Domain.Commands.Pessoa.Normalize;
using CQRSProjectModel.Domain.Core.Mediators;
using CQRSProjectModel.Domain.Core.Mediators.Normalize;
using CQRSProjectModel.Domain.Entities;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.ReadOnly;

namespace CQRSProjectModel.Application.Services
{
    public class PessoaAppService : AppService<Pessoa>, IPessoaAppService
    {
        private readonly IMapper mapper;
        private readonly IMediatorHandlerNormalize mediator;

        public PessoaAppService(IMapper mapper, IMediatorHandlerNormalize mediator, IRepositoryPessoaDenormalizeReadOnly repositoryPessoaDenormalizeReadOnly) : base(repositoryPessoaDenormalizeReadOnly)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        public async Task Create(PessoaViewModel pessoaViewModel)
        {
            var registerCommand = mapper.Map<CreatePessoaCommandNormalize>(pessoaViewModel);

            await mediator.SendCommand(registerCommand);
        }
    }
}
