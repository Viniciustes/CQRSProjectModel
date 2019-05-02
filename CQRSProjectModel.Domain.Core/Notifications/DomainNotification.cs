using CQRSProjectModel.Domain.Core.Events;
using System;

namespace CQRSProjectModel.Domain.Core.Notifications
{
    public class DomainNotification : Event
    {
        public DomainNotification(string key, string value)
        {
            Id = Guid.NewGuid();
            Version = 1;
            Key = key;
            Value = value;
        }

        public Guid Id { get; private set; }

        public string Key { get; private set; }

        public string Value { get; private set; }

        public int Version { get; private set; }
    }
}
