using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCLEstoque.Data;
using TCLEstoque.Models;

namespace TCLEstoque.Repositories
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly ApplicationDbContext _context;
        public EstoqueRepository(ApplicationDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Estoque> Estoques => _context.Estoques;
    }
}
