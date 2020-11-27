using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCLEstoque.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string Nome { get; set; }
        public ICollection<Movimentacao> Movimentacao { get; set; }
    }
}
