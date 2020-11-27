using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TCLEstoque.Data;
using TCLEstoque.Models;

namespace TCLEstoque.Controllers
{
    public class MovimentacoesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private int antigaQuantidade { get; set; }
        private int antigoEstoque { get; set; }

        public MovimentacoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Movimentacoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Movimentacoes.Include(m => m.Estoque).Include(m => m.Produto);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Movimentacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimentacao = await _context.Movimentacoes
                .Include(m => m.Estoque)
                .Include(m => m.Produto)
                .FirstOrDefaultAsync(m => m.MovimentacaoID == id);
            if (movimentacao == null)
            {
                return NotFound();
            }

            return View(movimentacao);
        }

        // GET: Movimentacoes/Create
        public IActionResult Create()
        {
            ViewData["EstoqueID"] = new SelectList(_context.Estoques, "Id", "Nome");
            ViewData["ProdutoID"] = new SelectList(_context.Produtos, "Id", "Nome");
            return View();
        }

        // POST: Movimentacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovimentacaoID,Quantidade,EstoqueID,ProdutoID")] Movimentacao movimentacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movimentacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EstoqueID"] = new SelectList(_context.Estoques, "Id", "Nome", movimentacao.EstoqueID);
            ViewData["ProdutoID"] = new SelectList(_context.Produtos, "Id", "Nome", movimentacao.ProdutoID);
            return View(movimentacao);
        }

        // GET: Movimentacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimentacao = await _context.Movimentacoes.FindAsync(id);
            if (movimentacao == null)
            {
                return NotFound();
            }          

            ViewData["EstoqueID"] = new SelectList(_context.Estoques, "Id", "Nome", movimentacao.EstoqueID);
            ViewData["ProdutoID"] = new SelectList(_context.Produtos, "Id", "Nome", movimentacao.ProdutoID);
            return View(movimentacao);
        }

        // POST: Movimentacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovimentacaoID,Quantidade,EstoqueID,ProdutoID")] Movimentacao movimentacao)
        {
            if (id != movimentacao.MovimentacaoID)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                try {
                    _context.Update(movimentacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovimentacaoExists(movimentacao.MovimentacaoID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EstoqueID"] = new SelectList(_context.Estoques, "Id", "Nome", movimentacao.EstoqueID);
            ViewData["ProdutoID"] = new SelectList(_context.Produtos, "Id", "Nome", movimentacao.ProdutoID);
            return View(movimentacao);
        }

        // GET: Movimentacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimentacao = await _context.Movimentacoes
                .Include(m => m.Estoque)
                .Include(m => m.Produto)
                .FirstOrDefaultAsync(m => m.MovimentacaoID == id);
            if (movimentacao == null)
            {
                return NotFound();
            }

            return View(movimentacao);
        }

        // POST: Movimentacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movimentacao = await _context.Movimentacoes.FindAsync(id);
            _context.Movimentacoes.Remove(movimentacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovimentacaoExists(int id)
        {
            return _context.Movimentacoes.Any(e => e.MovimentacaoID == id);
        }
    }
}
