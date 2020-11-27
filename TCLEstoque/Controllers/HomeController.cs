using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TCLEstoque.Models;
using TCLEstoque.Repositories;
using TCLEstoque.ViewModels;

namespace TCLEstoque.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMovimentacaoRepository _movimentacaoRepository;

        public HomeController(ILogger<HomeController> logger, IProdutoRepository produtoRepository, IMovimentacaoRepository movimentacaoRepository)
        {
            _logger = logger;
            _produtoRepository = produtoRepository;
            _movimentacaoRepository = movimentacaoRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Produtos = _produtoRepository.Produtos,
                QuantidadeTotalProduto = _movimentacaoRepository.GetMovimentacaoById(),
                Movimentacoes = _movimentacaoRepository.Movimentacoes,
            };            
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
