using CQRSProjectModel.Domain.Events;
using CQRSProjectModel.Domain.Requests;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Interfaces.Mediators
{
    public interface IMediatorHandler
    {
        Task SendRequest<T>(T request) where T : Request;

        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
