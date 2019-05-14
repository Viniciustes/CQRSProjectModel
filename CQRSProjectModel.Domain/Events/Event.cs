using MediatR;
using System;

namespace CQRSProjectModel.Domain.Events
{
    public abstract class Event : Message, INotification
    {
        protected Event()
        {
            Timestamp = DateTime.Now;
        }

        public DateTime Timestamp { get; private set; }
    }
}
