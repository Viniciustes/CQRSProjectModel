using CQRSProjectModel.Domain.Commands.Pessoa.Normalize;
using CQRSProjectModel.Domain.Core.Mediators.Normalize;
using CQRSProjectModel.Domain.Core.Notifications;
using CQRSProjectModel.Domain.Entities;
using CQRSProjectModel.Domain.Events.Pessoa;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize.WriteOnly;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.CommandsHandlers.Normalize
{
    public class PessoaCommandHandlerNormalize : CommandHandlerNormalize, IRequestHandler<CreatePessoaCommandNormalize>
    {
        private readonly IMediatorHandlerNormalize mediator;
        private readonly IRepositoryPessoaNormalizeWriteOnly repository;

        public PessoaCommandHandlerNormalize(IUnitOfWork unitOfWork, IMediatorHandlerNormalize mediator, IRepositoryPessoaNormalizeWriteOnly repository, INotificationHandler<DomainNotification> notification) : base(unitOfWork, mediator, notification)
        {
            this.mediator = mediator;
            this.repository = repository;
        }

        async Task<Unit> IRequestHandler<CreatePessoaCommandNormalize, Unit>.Handle(CreatePessoaCommandNormalize request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Unit.Value;
            }

            var pessoa = new Pessoa(Guid.NewGuid(), request.Nome, request.CPF, request.Nascimento, request.Telefone);

            await repository.Create(pessoa);

            if (Commit())
            {
                await mediator.RaiseEvent(new CreatedPessoaEvent(pessoa.Id, request.Nome, request.CPF, request.Nascimento, request.Telefone));
            }

            return Unit.Value;
        }
    }
}
