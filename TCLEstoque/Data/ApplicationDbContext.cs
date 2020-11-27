using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TCLEstoque.Models;

namespace TCLEstoque.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<LogAuditoria> LogAuditoria { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
    }
}
