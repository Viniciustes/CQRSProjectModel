using System.Threading;
using System.Threading.Tasks;
using CQRSProjectModel.Domain.Commands.Pessoa.Normalize;
using CQRSProjectModel.Domain.Core.Mediators.Normalize;
using CQRSProjectModel.Domain.Core.Notifications;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using MediatR;

namespace CQRSProjectModel.Domain.CommandsHandlers.Normalize
{
    public class PessoaCommandHandlerNormalize : CommandHandlerNormalize, IRequestHandler<CreatePessoaCommandNormalize>
    {
        private readonly IMediatorHandlerNormalize mediator;

        public PessoaCommandHandlerNormalize(IUnitOfWork unitOfWork, IMediatorHandlerNormalize mediator, INotificationHandler<DomainNotification> notification) : base (unitOfWork, mediator, notification)
        {
            this.mediator = mediator;
        }

        public Task Handle(CreatePessoaCommandNormalize request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.CompletedTask;
            }
            throw new System.NotImplementedException();
        }

        Task<Unit> IRequestHandler<CreatePessoaCommandNormalize, Unit>.Handle(CreatePessoaCommandNormalize request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
