using CQRSProjectModel.Domain.Requests.Pessoa.Normalize;

namespace CQRSProjectModel.Domain.Validations.Pessoa
{
    class CreatePessoaValidation : PessoaValidation<CreatePessoaRequestNormalize>
    {
        public CreatePessoaValidation()
        {
            ValidarNome();
        }
    }
}
