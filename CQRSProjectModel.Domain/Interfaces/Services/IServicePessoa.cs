using CQRSProjectModel.Domain.Models;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Interfaces.Services
{
    public interface IServicePessoa : IService<Pessoa>
    {
        Task Create(Pessoa pessoa);
    }
}
