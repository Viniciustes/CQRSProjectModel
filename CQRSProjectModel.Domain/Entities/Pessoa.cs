using CQRSProjectModel.Domain.Enums;
using System;
using System.Collections.Generic;

namespace CQRSProjectModel.Domain.Entities
{
    public class Pessoa
    {
        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        public string CPF { get; private set; }

        public DateTime Nascimento { get; private set; }

        public Genero Genero { get; private set; }

        public string Telefone { get; private set; }

        public IList<Endereco> Enderecos { get; private set; }
    }
}
