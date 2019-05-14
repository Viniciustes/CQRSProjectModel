using CQRSProjectModel.Domain.Validations.Pessoa;
using System;

namespace CQRSProjectModel.Domain.Requests.Pessoa
{
    public class CreateRequestPessoa : RequestPessoa
    {
        public CreateRequestPessoa(string nome, string cPF, DateTime nascimento, string telefone)
        {
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
