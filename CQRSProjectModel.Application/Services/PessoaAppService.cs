using AutoMapper;
using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Application.ViewModels;
using CQRSProjectModel.Domain.Interfaces.Services;
using CQRSProjectModel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSProjectModel.Application.Services
{
    public class PessoaAppService : AppService<Pessoa>, IPessoaAppService
    {
        private readonly IMapper _mapper;
        private readonly IServicePessoa _service;

        public PessoaAppService(IMapper mapper, IServicePessoa service) : base(service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task Create(PessoaViewModel pessoaViewModel)
        {
            var pessoa = _mapper.Map<Pessoa>(pessoaViewModel);

            await _service.Create(pessoa);
        }

        public void Update(PessoaViewModel pessoaViewModel)
        {
            Update(_mapper.Map<Pessoa>(pessoaViewModel));
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
