using AutoMapper;
using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Application.ViewModels;
using CQRSProjectModel.Domain.Interfaces.Repositories.Denormalize.ReadOnly;
using CQRSProjectModel.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSProjectModel.Application.Services
{
    public class PessoaAppService : AppService<Pessoa>, IPessoaAppService
    {
        private readonly IMapper mapper;

        public PessoaAppService(IMapper mapper, IRepositoryPessoaDenormalizeReadOnly repositoryPessoaDenormalizeReadOnly) : base(mapper, repositoryPessoaDenormalizeReadOnly)
        {
            this.mapper = mapper;
        }

        public Task Create(PessoaViewModel pessoaViewModel)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<PessoaViewModel>> IPessoaAppService.GetAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
