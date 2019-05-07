using CQRSProjectModel.Domain.Core.Events;
using System;

namespace CQRSProjectModel.Domain.Events.Pessoa
{
    public class CreatedPessoaEvent : Event
    {
        public CreatedPessoaEvent(Guid id, string nome, string cPF, DateTime nascimento, string telefone)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Nascimento = nascimento;
            Telefone = telefone;
        }

        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        public string CPF { get; private set; }

        public DateTime Nascimento { get; private set; }

        public string Telefone { get; private set; }
    }
}
