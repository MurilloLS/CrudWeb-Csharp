using CrudWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudWeb.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options) 
            : base(options) 
        { }

        public DbSet<Conteiner> Conteiner { get; set; }
        public DbSet<Movimentacao> Movimentacao { get; set; }
        public DbSet<Relato> Relato { get; set; }   
    }
}
