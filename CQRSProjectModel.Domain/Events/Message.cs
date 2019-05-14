using MediatR;

namespace CQRSProjectModel.Domain.Events
{
    public class Message : IRequest
    {
        public Message()
        {
            MessageType = GetType().Name;
        }

        public string MessageType { get; protected set; }
    }
}
