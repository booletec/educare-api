using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reluco.ReComex.Domain.Entities.Escola;

namespace Reluco.ReComex.Domain.Data.EscolaMaps
{
    public sealed class UnidadeEscolarMap : IEntityTypeConfiguration<UnidadeEscolar>
    {
        public void Configure(EntityTypeBuilder<UnidadeEscolar> builder)
        {
            builder.ToTable("UnidadeEscolar");

            builder.HasKey(k => k.Id)
                .HasName("UnidadeOperacionalId");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Descricao)           
                .HasMaxLength(500);

            //1 x 1 - unidade --> endereco
            builder
                .HasOne<Endereco>(s => s.Endereco)
                .WithOne(a => a.UnidadeEscolar)
                .HasForeignKey<Endereco>(e => e.UnidadeEscolarId);

            builder.Property(p => p.Desabilitado);
            builder.Property(p => p.ModifiedOn);
            builder.Property(p => p.CreatedOn);

           
        }
    }
}
