using System.Collections.Generic;
using TCLEstoque.Models;

namespace TCLEstoque.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public IEnumerable<Movimentacao> Movimentacoes { get; set; }
        public decimal QuantidadeTotalProduto { get; set; }
    }
}
