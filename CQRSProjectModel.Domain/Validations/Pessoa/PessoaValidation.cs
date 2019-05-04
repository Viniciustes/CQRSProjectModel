using CQRSProjectModel.Domain.Commands.Pessoa.Normalize;
using FluentValidation;
using System;

namespace CQRSProjectModel.Domain.Validations.Pessoa
{
    class PessoaValidation<TEntity> : AbstractValidator<TEntity> where TEntity : PessoaCommandNormalize
    {
        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }
    }
}
