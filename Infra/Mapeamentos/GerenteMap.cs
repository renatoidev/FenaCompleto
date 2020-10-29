using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mapeamentos
{
    public class GerenteMap : IEntityTypeConfiguration<Gerente>
    {
        public void Configure(EntityTypeBuilder<Gerente> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("Nome_Gerente")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(x => x.Cargo)
                .HasColumnName("Cargo_Gerente")
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder.HasMany(x => x.Analistas);






        }
    }
}
