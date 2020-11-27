using System.Collections.Generic;
using TCLEstoque.Models;

namespace TCLEstoque.Repositories
{
    public interface IEstoqueRepository
    {
        IEnumerable<Estoque> Estoques { get; }
    }
}
