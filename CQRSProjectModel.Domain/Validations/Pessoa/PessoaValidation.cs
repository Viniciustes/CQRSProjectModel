using CQRSProjectModel.Domain.Requests.Pessoa;
using FluentValidation;
using System;

namespace CQRSProjectModel.Domain.Validations.Pessoa
{
    class PessoaValidation<TEntity> : AbstractValidator<TEntity> where TEntity : PessoaRequest
    {
        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }
    }
}
