using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reluco.NewSchool.Domain.Entities.Escola;
using Reluco.ReComex.Domain.Entities.Escola;

namespace Reluco.ReComex.Domain.Data.EscolaMaps
{
    public sealed class AssiduidadeMap : IEntityTypeConfiguration<Assiduidade>
    {
        public void Configure(EntityTypeBuilder<Assiduidade> builder)
        {
            builder.ToTable("Assiduidade");

            builder.HasKey(k => k.Id)
                .HasName("AssiduidadeId");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

           

            builder.Property(p => p.TurmaId);
            builder.Property(p => p.ColaboradorId);
            builder.Property(p => p.AlunoId);


            //Relacionamento 1 x n turma --> Assiduidade
            builder.HasOne<Turma>(c => c.Turma)
                .WithMany(p => p.Assiduidades)
                .HasForeignKey(a => a.TurmaId);

            //Relacionamento 1 x n aluno --> Assiduidade
            builder.HasOne<Aluno>(c => c.Aluno)
                .WithMany(p => p.Assiduidades)
                .HasForeignKey(a => a.AlunoId);

            //Relacionamento 1 x n colaborador --> Assiduidade
            builder.HasOne<Colaborador>(c => c.Colaborador)
                .WithMany(p => p.Assiduidades)
                .HasForeignKey(a => a.ColaboradorId);

            builder.Property(p => p.Observacao);
            builder.Property(p => p.DataRegistro);
            builder.Property(p => p.TipoAssiduidade);
            

            builder.Property(p => p.Desabilitado);
            builder.Property(p => p.ModifiedOn);
            builder.Property(p => p.CreatedOn);

           
        }
    }
}
