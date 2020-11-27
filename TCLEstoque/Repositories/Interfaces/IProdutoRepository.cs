using System.Collections.Generic;
using TCLEstoque.Models;

namespace TCLEstoque.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
        Produto GetProdutoById(int produtoId);

    }
}
