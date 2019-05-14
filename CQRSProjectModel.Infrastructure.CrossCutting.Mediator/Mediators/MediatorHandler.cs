using CQRSProjectModel.Domain.Events;
using CQRSProjectModel.Domain.Interfaces.Mediators;
using CQRSProjectModel.Domain.Requests;
using MediatR;
using System.Threading.Tasks;

namespace CQRSProjectModel.Infrastructure.CrossCutting.Mediator.Mediators
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task RaiseEvent<T>(T @event) where T : Event
        {
            return _mediator.Publish(@event);
        }

        public async Task SendRequest<T>(T request) where T : Request
        {
            await _mediator.Send(request);
        }
    }
}
