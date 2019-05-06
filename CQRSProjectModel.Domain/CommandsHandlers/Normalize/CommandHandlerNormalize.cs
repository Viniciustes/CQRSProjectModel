using CQRSProjectModel.Domain.Core.Commands;
using CQRSProjectModel.Domain.Core.Mediators.Normalize;
using CQRSProjectModel.Domain.Core.Notifications;
using CQRSProjectModel.Domain.Interfaces.Repositories.Normalize;
using MediatR;

namespace CQRSProjectModel.Domain.CommandsHandlers.Normalize
{
    public class CommandHandlerNormalize
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediatorHandlerNormalize mediator;
        private readonly DomainNotificationHandler notification;

        public CommandHandlerNormalize(IUnitOfWork unitOfWork, IMediatorHandlerNormalize mediator, INotificationHandler<DomainNotification> notification)
        {
            this.mediator = mediator;
            this.unitOfWork = unitOfWork;
            this.notification = (DomainNotificationHandler)notification;
        }

        protected void NotifyValidationErrors(Command message)
        {
            foreach (var error in message.ValidationResult.Errors)
            {
                mediator.RaiseEvent(new DomainNotification(message.MessageType, error.ErrorMessage));
            }
        }

        public bool Commit()
        {
            if (notification.HasNotifications()) return false;

            if (unitOfWork.Commit()) return true;

            mediator.RaiseEvent(new DomainNotification("Commit", "Tivemos problemas ao salvar os dados."));

            return false;
        }
    }
}
