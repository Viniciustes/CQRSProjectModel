using CQRSProjectModel.Domain.Interfaces.Mediators;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Domain.Models;
using CQRSProjectModel.Domain.Notifications;
using CQRSProjectModel.Domain.Requests.Events.Pessoa;
using CQRSProjectModel.Domain.Requests.Pessoa;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.RequestsHandlers
{
    public class PessoaRequestHandler : RequestHandler, IRequestHandler<CreateRequestPessoa>
    {
        private readonly IMediatorHandler _mediator;
        private readonly IRepositoryNormalizePessoa _repository;

        public PessoaRequestHandler(IUnitOfWork unitOfWork, IMediatorHandler mediator, INotificationHandler<Notification> notification, IRepositoryNormalizePessoa repository) : base(unitOfWork, mediator, notification)
        {
            _mediator = mediator;
            _repository = repository;
        }

        public Task<Unit> Handle(CreateRequestPessoa request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);

                return Unit.Task;
            }

            var pessoa = new Pessoa(request.Id, request.Nome, request.CPF, request.Nascimento, request.Telefone);

            _repository.Create(pessoa);

            if (Commit())
            {
                _mediator.RaiseEvent(new CreateRequestEventPessoa(pessoa.Id, pessoa.Nome, pessoa.CPF, pessoa.Nascimento, pessoa.Telefone));
            }

            return Unit.Task;
        }
    }
}
