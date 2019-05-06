using MediatR;

namespace CQRSProjectModel.Domain.Core.Events
{
    public abstract class Message : IRequest
    {
        public Message()
        {
            MessageType = GetType().Name;
        }

        public string MessageType { get; protected set; }
    }
}
