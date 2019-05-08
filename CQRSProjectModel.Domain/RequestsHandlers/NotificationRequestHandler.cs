using CQRSProjectModel.Domain.Requests.Notification;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.RequestsHandlers
{
    class NotificationRequestHandler : IRequestHandler<NotificationRequest>
    {
        public Task<Unit> Handle(NotificationRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
