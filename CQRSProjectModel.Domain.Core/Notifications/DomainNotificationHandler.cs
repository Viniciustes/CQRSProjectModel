using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Core.Notifications
{
    public class DomainNotificationHandler : INotificationHandler<DomainNotification>
    {
        private readonly IList<DomainNotification> notifications;

        public DomainNotificationHandler()
        {
            notifications = new List<DomainNotification>();
        }

        public Task Handle(DomainNotification notification, CancellationToken cancellationToken)
        {
            notifications.Add(notification);

            return Task.CompletedTask;
        }

        public virtual bool HasNotifications()
        {
            return GetNotifications().Any();
        }

        public virtual IList<DomainNotification> GetNotifications()
        {
            return notifications;
        }
    }
}
