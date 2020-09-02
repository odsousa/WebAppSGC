using Microsoft.EntityFrameworkCore;
using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.Data
{
    public class ClienteContext : DbContext /*Classe de contexto herda sempre de DBContext*/ 
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
          
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente"); /*Informa ao entity o nome da tabela (por padrão usasse o nome da propriedade) */
        }

    }
}
