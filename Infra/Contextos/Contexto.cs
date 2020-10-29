using Dominio.Entidades;
using Infra.Mapeamentos;
using Microsoft.EntityFrameworkCore;

namespace Infra.Contextos
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
        }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Analista> Analistas { get; set; }
        public DbSet<Estagiario> Estagiarios { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnalistaMap());
            modelBuilder.ApplyConfiguration(new EstagiarioMap());
            modelBuilder.ApplyConfiguration(new GerenteMap());
            modelBuilder.ApplyConfiguration(new TecnicoMap());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
