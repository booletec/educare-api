using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reluco.ReComex.Domain.Entities.Escola;

namespace Reluco.ReComex.Domain.Data.EscolaMaps
{
    public sealed class ResponsavelMap : IEntityTypeConfiguration<Responsavel>
    {
        public void Configure(EntityTypeBuilder<Responsavel> builder)
        {
            builder.ToTable("Responsavel");

            builder.HasKey(k => k.Id)
                .HasName("ResponsavelId");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.SobreNome)
                .HasMaxLength(500);

            builder.Property(p => p.NascidoEm);

            builder.Property(p => p.GrauParentesco);

            builder.Property(p => p.ApplicationUserId);
            builder.Property(p => p.Cpf);
            builder.Property(p => p.Identidade);

            builder.Property(p => p.Desabilitado);               
            builder.Property(p => p.ModifiedOn);
            builder.Property(p => p.CreatedOn);

           
        }
    }
}
