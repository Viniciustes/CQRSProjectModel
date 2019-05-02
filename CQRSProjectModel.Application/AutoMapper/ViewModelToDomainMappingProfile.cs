using AutoMapper;
using CQRSProjectModel.Application.ViewModels;
using CQRSProjectModel.Domain.Entities;
using CQRSProjectModel.Domain.Enums;

namespace CQRSProjectModel.Application.AutoMapper
{
    class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PessoaViewModel, Pessoa>()
               .ConstructUsing(x => new Pessoa(x.Nome, x.CPF, x.Nascimento, (Genero)x.Genero, x.Telefone));

            CreateMap<PessoaViewModel, Pessoa>()
              .ConstructUsing(x => new Pessoa(x.Id, x.Nome, x.CPF, x.Nascimento, (Genero)x.Genero, x.Telefone));
        }
    }
}
