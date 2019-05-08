using CQRSProjectModel.Domain.Requests.Notification;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.RequestsHandlers
{
    public class NotificationRequestHandler : INotificationHandler<NotificationRequest>
    {
        //public Task<Unit> Handle(NotificationRequest request, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        Task INotificationHandler<NotificationRequest>.Handle(NotificationRequest notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
