namespace CQRSProjectModel.Domain.Requests
{
    class RequestMessage
    {
        public RequestMessage()
        {
            MessageType = GetType().Name;
        }

        public string MessageType { get; protected set; }
    }
}
