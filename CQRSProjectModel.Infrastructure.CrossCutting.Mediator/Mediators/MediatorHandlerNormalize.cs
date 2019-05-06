using CQRSProjectModel.Domain.Core.Commands;
using CQRSProjectModel.Domain.Core.Events;
using CQRSProjectModel.Domain.Core.Mediators.Normalize;
using MediatR;
using System.Threading.Tasks;

namespace CQRSProjectModel.Infrastructure.CrossCutting.Mediator.Mediators
{
    public sealed class MediatorHandlerNormalize : IMediatorHandlerNormalize
    {
        private readonly IMediator mediator;

        public MediatorHandlerNormalize(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task RaiseEvent<T>(T @event) where T : Event
        {
            return mediator.Publish(@event);
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return mediator.Send(command);
        }
    }
}
