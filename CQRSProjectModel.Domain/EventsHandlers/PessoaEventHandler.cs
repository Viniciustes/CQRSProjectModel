using CQRSProjectModel.Domain.Commands.Pessoa.Denormalize;
using CQRSProjectModel.Domain.Core.Mediators.Denormalize;
using CQRSProjectModel.Domain.Events.Pessoa;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.EventsHandlers
{
    public class PessoaEventHandler : INotificationHandler<CreatedPessoaEvent>
    {
        private readonly IMediatorHandlerDenormalize mediator;

        public PessoaEventHandler(IMediatorHandlerDenormalize mediator)
        {
            this.mediator = mediator;
        }

        public Task Handle(CreatedPessoaEvent notification, CancellationToken cancellationToken)
        {
            mediator.SendDenormalize(new CreatePessoaCommandDenormalize(notification.Id, notification.Nome, notification.CPF, notification.Nascimento, notification.Telefone));

            return Task.CompletedTask;
        }
    }
}
