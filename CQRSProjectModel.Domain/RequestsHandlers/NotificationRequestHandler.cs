using CQRSProjectModel.Domain.Notifications;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.RequestsHandlers
{
    public class NotificationRequestHandler : INotificationHandler<Notification>
    {
        private readonly List<Notification> _notifications;

        public NotificationRequestHandler()
        {
            _notifications = new List<Notification>();
        }

        public virtual List<Notification> GetNotifications()
        {
            return _notifications;
        }

        public Task Handle(Notification notification, CancellationToken cancellationToken)
        {
            _notifications.Add(notification);

            return Task.CompletedTask;
        }

        public virtual bool HasNotifications()
        {
            return GetNotifications().Any();
        }
    }
}
