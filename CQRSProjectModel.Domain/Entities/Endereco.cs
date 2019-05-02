using CQRSProjectModel.Domain.Enums;
using System;

namespace CQRSProjectModel.Domain.Entities
{
    public class Endereco
    {
        public Guid Id { get; private set; }

        public string CEP { get; private set; }

        public string Logradouro { get; private set; }

        public string Cidade { get; private set; }

        public TipoEndereco TipoEndereco { get; private set; }
    }
}
