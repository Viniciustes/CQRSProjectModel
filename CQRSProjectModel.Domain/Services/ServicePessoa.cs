using CQRSProjectModel.Domain.Interfaces.Mediators;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Domain.Interfaces.Services;
using CQRSProjectModel.Domain.Models;
using CQRSProjectModel.Domain.Requests.Pessoa;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Services
{
    public class ServicePessoa : Service<Pessoa>, IServicePessoa
    {
        private readonly IMediatorHandler _mediator;

        public ServicePessoa(IMediatorHandler mediator, IRepositoryNormalizePessoa repositoryNormalize, IRepositoryDenormalizePessoa repositoryDenormalize) : base(repositoryNormalize, repositoryDenormalize)
        {
            _mediator = mediator;
        }

        public async Task Create(Pessoa pessoa)
        {
            var createPessoaRequest = new CreateRequestPessoa(pessoa.Nome, pessoa.CPF, pessoa.Nascimento, pessoa.Telefone);

            await _mediator.SendRequest(createPessoaRequest);
        }
    }
}
