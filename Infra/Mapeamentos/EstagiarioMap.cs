using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mapeamentos
{
    public class EstagiarioMap : IEntityTypeConfiguration<Estagiario>
    {
        public void Configure(EntityTypeBuilder<Estagiario> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("Nome_Estagiario")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(x => x.Cargo)
                .HasColumnName("Cargo_Estagiario")
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder.HasOne(x => x.Supervisor);
        }
    }
}
