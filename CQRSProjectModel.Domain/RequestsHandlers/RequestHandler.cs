using CQRSProjectModel.Domain.Interfaces.Mediators;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using CQRSProjectModel.Domain.Notifications;
using CQRSProjectModel.Domain.Requests;
using MediatR;

namespace CQRSProjectModel.Domain.RequestsHandlers
{
    public class RequestHandler
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediatorHandler _mediator;
        private readonly NotificationRequestHandler _notification;

        public RequestHandler(IUnitOfWork unitOfWork, IMediatorHandler mediator, INotificationHandler<Notification> notification)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
            _notification = (NotificationRequestHandler)notification;
        }

        protected void NotifyValidationErrors(Request request)
        {
            foreach (var error in request.ValidationResult.Errors)
            {
                _mediator.RaiseEvent(new Notification(request.MessageType, error.ErrorMessage));
            }
        }

        public bool Commit()
        {
            if (_notification.HasNotifications()) return false;

            if (_unitOfWork.Commit()) return true;

            _mediator.RaiseEvent(new Notification("Commit", "Tivemos problemas ao salvar os dados."));

            return false;
        }
    }
}
