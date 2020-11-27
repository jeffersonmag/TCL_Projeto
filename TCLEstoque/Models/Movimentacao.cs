using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TCLEstoque.Data;

namespace TCLEstoque.Models
{
    public class Movimentacao
    {
        private readonly ApplicationDbContext _context;

        public int MovimentacaoID { get; set; }
        public int Quantidade { get; set; }
        public int EstoqueID { get; set; }
        public int ProdutoID { get; set; }
        public Estoque Estoque { get; set; }
        public Produto Produto { get; set; }
    }
}

