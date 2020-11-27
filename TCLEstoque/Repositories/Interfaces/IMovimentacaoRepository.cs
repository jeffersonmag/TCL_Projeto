using System.Collections.Generic;
using TCLEstoque.Models;

namespace TCLEstoque.Repositories
{
    public interface IMovimentacaoRepository
    {
        IEnumerable<Movimentacao> Movimentacoes { get; }
        int GetMovimentacaoById();
    }
}
