using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CQRSProjectModel.WebApplication.Controllers
{
    public class PessoasController : Controller
    {
        private readonly IPessoaAppService _pessoaAppService;

        public PessoasController(IPessoaAppService pessoaAppService)
        {
            _pessoaAppService = pessoaAppService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _pessoaAppService.GetAllAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,CPF,Nascimento,TipoPessoa,Telefone")] PessoaViewModel pessoaViewModel)
        {
            if (ModelState.IsValid)
            {
                await _pessoaAppService.Create(pessoaViewModel);

                return RedirectToAction(nameof(Index));
            }

            return View(pessoaViewModel);
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            return View(await GetById((Guid)id));
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            return View(await GetById((Guid)id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,Nome,CPF,Nascimento,TipoPessoa,Telefone")] PessoaViewModel pessoaViewModel)
        {
            if (id != pessoaViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _pessoaAppService.Update(pessoaViewModel);

                return RedirectToAction(nameof(Index));
            }
            return View(pessoaViewModel);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            return View(await GetById((Guid)id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _pessoaAppService.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        private async Task<IActionResult> GetById(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoa = await _pessoaAppService.GetById((Guid)id);

            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }
    }
}