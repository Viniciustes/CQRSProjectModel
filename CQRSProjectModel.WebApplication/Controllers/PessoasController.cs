using CQRSProjectModel.Application.Interfaces;
using CQRSProjectModel.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRSProjectModel.WebApplication.Controllers
{
    public class PessoasController : Controller
    {
        private readonly IPessoaAppService pessoaAppService;

        public PessoasController(IPessoaAppService pessoaAppService)
        {
            this.pessoaAppService = pessoaAppService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await pessoaAppService.GetAllAsync());
        }

        //GET: Pessoas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,CPF,Nascimento,TipoPessoa,Telefone")] PessoaViewModel pessoaViewModel)
        {
            if (ModelState.IsValid)
            {
                await pessoaAppService.Create(pessoaViewModel);

                return RedirectToAction(nameof(Index));
            }

            return View(pessoaViewModel);
        }

        //// GET: Pessoas/Details/5
        //public async Task<IActionResult> Details(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pessoa = await _context.Pessoa
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (pessoa == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(pessoa);
        //}



        //// GET: Pessoas/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pessoa = await _context.Pessoa.FindAsync(id);
        //    if (pessoa == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(pessoa);
        //}

        //// POST: Pessoas/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nome,CPF,Nascimento,TipoPessoa,Telefone")] PessoaViewModel pessoaViewModel)
        //{
        //    if (id != pessoa.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(pessoa);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PessoaExists(pessoa.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(pessoa);
        //}

        //// GET: Pessoas/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pessoa = await _context.Pessoa
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (pessoa == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(pessoa);
        //}

        //// POST: Pessoas/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var pessoa = await _context.Pessoa.FindAsync(id);

        //    _context.Pessoa.Remove(pessoa);

        //    await _context.SaveChangesAsync();

        //    return RedirectToAction(nameof(Index));
        //}

        //private bool PessoaExists(Guid id)
        //{
        //    return _context.Pessoa.Any(e => e.Id == id);
        //}

    }
}