using AutoMapper;
using CQRSProjectModel.Application.ViewModels;
using CQRSProjectModel.Domain.Commands.Pessoa.Normalize;

namespace CQRSProjectModel.Application.AutoMapper
{
    class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PessoaViewModel, CreatePessoaCommandNormalize>()
               .ConstructUsing(x => new CreatePessoaCommandNormalize(x.Nome, x.CPF, x.Nascimento, x.Telefone));

            //CreateMap<PessoaViewModel, Pessoa>()
            //  .ConstructUsing(x => new Pessoa(x.Id, x.Nome, x.CPF, x.Nascimento, (Genero)x.Genero, x.Telefone));
        }
    }
}
