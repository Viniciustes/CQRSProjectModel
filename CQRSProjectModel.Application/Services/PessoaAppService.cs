using AutoMapper;
using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Application.ViewModels;
using CQRSProjectModel.Domain.Entities;
using CQRSProjectModel.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSProjectModel.Application.Services
{
    public class PessoaAppService : AppService<Pessoa>, IPessoaAppService
    {
        private readonly IMapper _mapper;

        public PessoaAppService(IMapper mapper, IServicePessoa service) : base(service)
        {
            _mapper = mapper;
        }

        public async Task Create(PessoaViewModel pessoaViewModel)
        {
            await Create(_mapper.Map<Pessoa>(pessoaViewModel));
        }

        public async Task Update(PessoaViewModel pessoaViewModel)
        {
            await Update(_mapper.Map<Pessoa>(pessoaViewModel));
        }

        async Task<IEnumerable<PessoaViewModel>> IAppService<PessoaViewModel>.GetAllAsync()
        {
            return _mapper.Map<IEnumerable<PessoaViewModel>>(await GetAllAsync());
        }

        async Task<PessoaViewModel> IAppService<PessoaViewModel>.GetById(Guid guid)
        {
            return _mapper.Map<PessoaViewModel>(await GetById(guid));
        }
    }
}
