using CQRSProjectModel.Domain.Core.Events;
using System;

namespace CQRSProjectModel.Domain.Events.Pessoa
{
    public class PessoaCreatedEvent : Event
    {
        public PessoaCreatedEvent(string nome, string cPF, DateTime nascimento, string telefone)
        {
            Nome = nome;
            CPF = cPF;
            Nascimento = nascimento;
            Telefone = telefone;
        }

        public string Nome { get; private set; }

        public string CPF { get; private set; }

        public DateTime Nascimento { get; private set; }

        public string Telefone { get; private set; }
    }
}
