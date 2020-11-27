using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCLEstoque.Models
{
    public class Produto
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [StringLength(150)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Preço do Produto")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        [Display(Name = "Data de Cadastro")]
        public DateTime DataCriacao { get; set; }
        public ICollection<Movimentacao> Movimentacao { get; set; }

    }
}
