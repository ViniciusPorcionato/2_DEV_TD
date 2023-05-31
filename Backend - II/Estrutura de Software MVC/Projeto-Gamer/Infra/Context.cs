using Microsoft.EntityFrameworkCore;
using Projeto_Gamer.Models;

namespace Projeto_Gamer.Infra
{
    public class Context:DbContext
    {
        public Context()
        {
            
        }

        public Context(DbContextOptions<Context> options) : base (options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // string de conexão para base de dados
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-2KJISQH\\SENAI; initial catalog = gamerTarde; User Id = sa; pwd = Senai@134; TrustServerCertificate = true");
            }
        }

        public DbSet<Jogador> Jogador {get; set;}
        public DbSet<Equipe> Equipe {get; set;}


    }
}