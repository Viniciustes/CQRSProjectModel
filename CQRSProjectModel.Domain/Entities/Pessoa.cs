using CQRSProjectModel.Domain.Core.Entities;
using CQRSProjectModel.Domain.Enums;
using System;

namespace CQRSProjectModel.Domain.Entities
{
    public class Pessoa : Entity
    {
        // Construtor em banco para uso do EF.
        protected Pessoa() { }

        // Construtor para criação da entidade.
        public Pessoa(string nome, string cPF, DateTime nascimento, Genero genero, string telefone)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            CPF = cPF;
            Nascimento = nascimento;
            Genero = genero;
            Telefone = telefone;
        }

        // Construtor para atualização da entidade.
        public Pessoa(Guid id, string nome, string cPF, DateTime nascimento, Genero genero, string telefone)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Nascimento = nascimento;
            Genero = genero;
            Telefone = telefone;
        }

        public string Nome { get; private set; }

        public string CPF { get; private set; }

        public DateTime Nascimento { get; private set; }

        public Genero Genero { get; private set; }

        public string Telefone { get; private set; }
    }
}
