using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCLEstoque.Data;
using TCLEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace TCLEstoque.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;
        public ProdutoRepository(ApplicationDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Produto> Produtos => _context.Produtos.Include(c => c.Movimentacao);

        public Produto GetProdutoById(int produtoId) => _context.Produtos.FirstOrDefault(l => l.Id == produtoId);
    }
}
