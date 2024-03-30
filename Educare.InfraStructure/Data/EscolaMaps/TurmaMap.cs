using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reluco.ReComex.Domain.Entities.Escola;

namespace Reluco.ReComex.Domain.Data.EscolaMaps
{
    public sealed class TurmaMap : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.ToTable("Turma");

            builder.HasKey(k => k.Id)
                .HasName("TurmaId");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.AnoLetivo);
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Descricao)           
                .HasMaxLength(500);

            builder.Property(p => p.Serie).IsRequired();
            builder.Property(p => p.TipoEnsino).IsRequired();

            builder.Property(p => p.IdadeMinima).IsRequired();
            builder.Property(p => p.IdadeMaxima).IsRequired();
            builder.Property(p => p.Vagas);
            builder.Property(p => p.Turno);

            //Relacionamento de 1 pra n (uma turma tem n alunos) 
            builder
                .HasMany<Aluno>(c => c.Alunos)
                .WithOne(a => a.Turma)
                .HasForeignKey(c => c.TurmaId);

            //Relacionamento 1 x n (1 Turma pode ter n professores)
            builder
                 .HasMany<Colaborador>(c => c.Professores)
                 .WithOne(a => a.Turma)
                 .HasForeignKey(c => c.TurmaId);

            builder.Property(p => p.Desabilitado);
            builder.Property(p => p.ModifiedOn);
            builder.Property(p => p.CreatedOn);

           
        }
    }
}
