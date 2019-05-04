using CQRSProjectModel.Domain.Validations.Pessoa;
using System;

namespace CQRSProjectModel.Domain.Commands.Pessoa.Normalize
{
    public class CreatePessoaCommandNormalize : PessoaCommandNormalize
    {
        public CreatePessoaCommandNormalize(string nome, string cPF, DateTime nascimento, string telefone)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            CPF = cPF;
            Nascimento = nascimento;
            Telefone = telefone;
        }

        public override bool IsValid()
        {
            ValidationResult = new CreatePessoaValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
