using CQRSProjectModel.Domain.Core.Commands;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Core.Mediators.Denormalize
{
    public interface IMediatorHandlerDenormalize
    {
        Task SendDenormalize<T>(T command) where T : Command;
    }
}
