using CQRSProjectModel.Domain.Core.Mediators.Normalize;
using CQRSProjectModel.Domain.Events.Pessoa;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.EventsHandlers
{
    public class PessoaEventHandler : INotificationHandler<PessoaCreatedEvent>
    {
        private readonly IMediatorHandlerNormalize mediator;

        public Task Handle(PessoaCreatedEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
