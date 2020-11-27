using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCLEstoque.Data;
using TCLEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace TCLEstoque.Repositories
{
    public class MovimentacaoRepository : IMovimentacaoRepository
    {
        private readonly ApplicationDbContext _context;
        public MovimentacaoRepository(ApplicationDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Movimentacao> Movimentacoes => _context.Movimentacoes.Include(m => m.Estoque).Include(m => m.Produto);
        public int GetMovimentacaoById() => _context.Movimentacoes.Select(c => c.Quantidade).Sum();

    }
}
