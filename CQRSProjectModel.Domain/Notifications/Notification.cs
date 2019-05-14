using CQRSProjectModel.Domain.Events;
using System;

namespace CQRSProjectModel.Domain.Notifications
{
    public class Notification : Event
    {
        public Notification(string key, string value)
        {
            NotificationId = Guid.NewGuid();
            Key = key;
            Value = value;
            Version = 1;
        }

        public Guid NotificationId { get; private set; }

        public string Key { get; private set; }

        public string Value { get; private set; }

        public int Version { get; private set; }
    }
}
