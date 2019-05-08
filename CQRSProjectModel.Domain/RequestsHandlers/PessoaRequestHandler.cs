using CQRSProjectModel.Domain.Requests.Pessoa.Normalize;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.RequestsHandlers
{
    class PessoaRequestHandler : IRequestHandler<CreatePessoaRequestNormalize>
    {
        public Task<Unit> Handle(CreatePessoaRequestNormalize request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
