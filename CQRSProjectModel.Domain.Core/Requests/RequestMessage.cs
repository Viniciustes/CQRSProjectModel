namespace CQRSProjectModel.Domain.Core.Requests
{
    public class RequestMessage
    {
        public RequestMessage()
        {
            MessageType = GetType().Name;
        }

        public string MessageType { get; protected set; }
    }
}
