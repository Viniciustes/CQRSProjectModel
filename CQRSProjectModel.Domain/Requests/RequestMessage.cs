namespace CQRSProjectModel.Domain.Requests
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
