using CQRSProjectModel.Domain.Requests.Pessoa;
using FluentValidation;
using System;

namespace CQRSProjectModel.Domain.Validations.Pessoa
{
    class PessoaValidation<TEntity> : AbstractValidator<TEntity> where TEntity : RequestPessoa
    {
        protected void ValidarId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }

        protected void ValidarNome()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Voce precisa preencher o nome.")
                .Length(5, 150).WithMessage("O nome deve ter entre 2 e 150 caracteres.");
        }
    }
}
