using CQRSProjectModel.Domain.Events;
using System;

namespace CQRSProjectModel.Domain.Requests.Events.Pessoa
{
    public class CreateRequestEventPessoa : Event
    {
        public CreateRequestEventPessoa(Guid id, string nome, string cPF, DateTime nascimento, string telefone)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Nascimento = nascimento;
            Telefone = telefone;
        }

        public Guid Id { get; protected set; }

        public string Nome { get; protected set; }

        public string CPF { get; protected set; }

        public DateTime Nascimento { get; protected set; }

        public string Telefone { get; protected set; }
    }
}
