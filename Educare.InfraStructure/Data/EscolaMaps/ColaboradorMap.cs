using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reluco.ReComex.Domain.Entities.Escola;
using Reluco.ReComex.Domain.Entities.Identity;

namespace Reluco.ReComex.Domain.Data.EscolaMaps
{
    public sealed class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder
                .ToTable("Colaborador");

            builder
                .HasKey(k => k.Id)
                .HasName("ColaboradorId");

            builder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.SobreNome)           
                .HasMaxLength(500);

            builder.Property(p => p.CargoId);

            builder.Property(p => p.ApplicationUserId);
            builder.Property(p => p.Cpf);
            builder.Property(p => p.Identidade);

            builder.Property(p => p.Desabilitado);               
            builder.Property(p => p.ModifiedOn);
            builder.Property(p => p.CreatedOn);
        }
    }
}
