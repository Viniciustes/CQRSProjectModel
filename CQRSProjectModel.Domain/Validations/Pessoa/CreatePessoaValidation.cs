using CQRSProjectModel.Domain.Requests.Pessoa;

namespace CQRSProjectModel.Domain.Validations.Pessoa
{
    class CreatePessoaValidation : PessoaValidation<CreateRequestPessoa>
    {
        public CreatePessoaValidation()
        {
            ValidarNome();
        }
    }
}
