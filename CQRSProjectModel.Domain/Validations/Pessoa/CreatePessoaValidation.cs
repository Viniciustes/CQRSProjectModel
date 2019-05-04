using CQRSProjectModel.Domain.Commands.Pessoa.Normalize;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSProjectModel.Domain.Validations.Pessoa
{
    class CreatePessoaValidation : PessoaValidation<CreatePessoaCommandNormalize>
    {
        public CreatePessoaValidation()
        {

        }
    }
}
