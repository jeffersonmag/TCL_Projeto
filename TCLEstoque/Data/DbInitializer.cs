using System;
using System.Linq;
using TCLEstoque.Models;

namespace TCLEstoque.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // procura por qualquer Produto
            if (context.Produtos.Any())
            {
                return;  //O banco foi inicializado
            }

            var estudantes = new Produto[]
            {
            new Produto{Nome="Roupa X",Preco=100.00M,DataCriacao=DateTime.Parse("2020-09-01")},
            new Produto{Nome="Tênis B",Preco=25.42M,DataCriacao=DateTime.Parse("2019-09-01")},
            new Produto{Nome="Skate",Preco=400.85M,DataCriacao=DateTime.Parse("2020-09-01")},
            new Produto{Nome="Meia Cano Alto",Preco=78.5M,DataCriacao=DateTime.Parse("2020-10-01")},
            new Produto{Nome="Cadarço",Preco=77.98M,DataCriacao=DateTime.Parse("2019-09-01")},
            };
            foreach (Produto s in estudantes)
            {
                context.Produtos.Add(s);
            }
            context.SaveChanges();

            var estoques = new Estoque[]
            {
            new Estoque{Nome="Estoque Av Patriarca",},
            new Estoque{Nome="Estoque Av Dom Pedro",},
            new Estoque{Nome="Estoque Av Fiusa",},
            };
            foreach (Estoque c in estoques)
            {
                context.Estoques.Add(c);
            }
            context.SaveChanges();

            var movimentacoes = new Movimentacao[]
            {
            new Movimentacao{EstoqueID=1,ProdutoID=1,Quantidade=5},
            new Movimentacao{EstoqueID=1,ProdutoID=3,Quantidade=10},
            new Movimentacao{EstoqueID=1,ProdutoID=2,Quantidade=1},
            new Movimentacao{EstoqueID=2,ProdutoID=4,Quantidade=4},
            new Movimentacao{EstoqueID=3,ProdutoID=3,Quantidade=5},
            };
            foreach (Movimentacao e in movimentacoes)
            {
                context.Movimentacoes.Add(e);
            }
            context.SaveChanges();
        }
    }
}