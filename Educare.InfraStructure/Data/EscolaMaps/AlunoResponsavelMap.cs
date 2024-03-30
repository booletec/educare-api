using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reluco.ReComex.Domain.Entities.Escola;

namespace Reluco.ReComex.Domain.Data.EscolaMaps
{
    public class AlunoResponsavelMap : IEntityTypeConfiguration<AlunoResponsavel>
    {
        public void Configure(EntityTypeBuilder<AlunoResponsavel> builder)
        {


            builder.ToTable("AlunoResponsavel");

            builder.HasKey(k => k.Id)
                .HasName("AlunoResponsavelId");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

           // builder.HasKey(sc => new { sc.AlunoId, sc.ResponsavelId });

            builder
                .HasOne<Aluno>(sc => sc.Aluno)
                .WithMany(s => s.Responsaveis)
                .HasForeignKey(sc => sc.AlunoId);

            builder
                .HasOne<Responsavel>(sc => sc.Responsavel)
                .WithMany(s => s.Alunos)
                .HasForeignKey(sc => sc.ResponsavelId);
        }
    }
}
