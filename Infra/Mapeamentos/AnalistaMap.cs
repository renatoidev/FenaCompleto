using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mapeamentos
{
    public class AnalistaMap : IEntityTypeConfiguration<Analista>
    {
        public void Configure(EntityTypeBuilder<Analista> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("Nome_Analista")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(x => x.Cargo)
                .HasColumnName("Cargo_Analista")
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder.HasOne(x => x.Supervisor);

            builder.HasMany(x => x.Tecnicos);

            builder.HasMany(x => x.Estagiarios);
        }
    }
}
