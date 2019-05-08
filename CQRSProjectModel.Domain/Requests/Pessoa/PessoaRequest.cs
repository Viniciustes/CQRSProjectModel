using System;

namespace CQRSProjectModel.Domain.Requests.Pessoa
{
    public abstract class PessoaRequest : Request
    {
        public Guid Id { get; protected set; }

        public string Nome { get; protected set; }

        public string CPF { get; protected set; }

        public DateTime Nascimento { get; protected set; }

        public string Telefone { get; protected set; }
    }
}
