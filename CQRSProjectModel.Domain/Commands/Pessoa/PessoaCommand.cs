using CQRSProjectModel.Domain.Core.Commands;
using System;

namespace CQRSProjectModel.Domain.Commands.Pessoa
{
    public abstract class PessoaCommand : Command
    {
        public Guid Id { get; protected set; }

        public string Nome { get; protected set; }

        public string CPF { get; protected set; }

        public DateTime Nascimento { get; protected set; }

        public string Telefone { get; protected set; }
    }
}
