using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reluco.NewSchool.Domain.Entities.Escola;
using Reluco.ReComex.Domain.Entities.Escola;

namespace Reluco.ReComex.Domain.Data.EscolaMaps
{
    public sealed class DiarioBordoMap : IEntityTypeConfiguration<DiarioBordo>
    {
        public void Configure(EntityTypeBuilder<DiarioBordo> builder)
        {
            builder.ToTable("DiarioBordo");

            builder.HasKey(k => k.Id)
                .HasName("DiarioBordoId");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Descricao);
            builder.Property(p => p.CriadorPorId);
            builder.Property(p => p.AlunoId);

            //Relacionamento 1 x n aluno --> Diario Bordo
            builder.HasOne<Aluno>(c => c.Aluno)
                .WithMany(p => p.DiariosBordo)
                .HasForeignKey(a => a.AlunoId);

            //Relacionamento 1 x n colaborador --> Diario Bordo
            builder.HasOne<Colaborador>(c => c.CriadoPor)
                .WithMany(p => p.DiariosBordo)
                .HasForeignKey(a => a.CriadorPorId);

            builder.Property(p => p.Desabilitado);
            builder.Property(p => p.ModifiedOn);
            builder.Property(p => p.CreatedOn);

           
        }
    }
}
