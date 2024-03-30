using Educare.Core.School.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Reluco.ReComex.Domain.Data.EscolaMaps
{
    public sealed class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(k => k.Id)
                .HasName("AlunoId");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.SobreNome)           
                .HasMaxLength(500);

            builder.Property(p => p.Matricula)
              .HasMaxLength(20);

            builder.Property(p => p.Sexo);
             
            builder.Property(p => p.ContratoId);

            builder.Property(p => p.ApplicationUserId);
            builder.Property(p => p.Cpf);
            builder.Property(p => p.Identidade);

          

            //builder.Property(p => p.Contrato);
            builder.Property(p => p.Desabilitado);               
            builder.Property(p => p.ModifiedOn);
            builder.Property(p => p.CreatedOn);

           
        }
    }
}
