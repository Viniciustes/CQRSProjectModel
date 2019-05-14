using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize;
using CQRSProjectModel.Domain.Models;
using CQRSProjectModel.Domain.Requests.Events.Pessoa;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.RequestsHandlers.Events
{
    public class RequestHandlerEventPessoa : INotificationHandler<CreateRequestEventPessoa>
    {
        private readonly IRepositoryDenormalizePessoa _repository;

        public RequestHandlerEventPessoa(IRepositoryDenormalizePessoa repository)
        {
            _repository = repository;
        }

        public Task Handle(CreateRequestEventPessoa notification, CancellationToken cancellationToken)
        {
            var pessoa = new Pessoa(notification.Id, notification.Nome, notification.CPF, notification.Nascimento, notification.Telefone);

            _repository.Create(pessoa);

            return Task.CompletedTask;
        }
    }
}
