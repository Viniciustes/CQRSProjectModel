using AutoMapper;
using CQRSProjectModel.Application.ViewModels;
using CQRSProjectModel.Domain.Models;

namespace CQRSProjectModel.Application.AutoMapper
{
    class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Pessoa, PessoaViewModel>();
        }
    }
}
