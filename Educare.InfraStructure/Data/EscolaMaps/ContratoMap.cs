using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reluco.ReComex.Domain.Entities.Escola;

namespace Reluco.ReComex.Domain.Data.EscolaMaps
{
    public sealed class ContratoMap : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.ToTable("Contrato");

            builder.HasKey(k => k.Id)
                .HasName("ContratoId");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Desricao);
            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p => p.Template).IsRequired();
            builder.Property(p => p.Valor).IsRequired();
            

            builder.Property(p => p.Desabilitado);
                
            builder.Property(p => p.ModifiedOn);

            builder.Property(p => p.CreatedOn);

           
        }
    }
}
