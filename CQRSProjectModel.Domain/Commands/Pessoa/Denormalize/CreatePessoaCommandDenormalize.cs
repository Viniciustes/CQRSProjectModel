using System;

namespace CQRSProjectModel.Domain.Commands.Pessoa.Denormalize
{
    public class CreatePessoaCommandDenormalize : PessoaCommand
    {
        public CreatePessoaCommandDenormalize(Guid id, string nome, string cPF, DateTime nascimento, string telefone)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Nascimento = nascimento;
            Telefone = telefone;
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}
