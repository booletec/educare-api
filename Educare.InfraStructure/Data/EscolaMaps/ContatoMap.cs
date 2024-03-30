using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reluco.ReComex.Domain.Entities.Escola;
using Reluco.ReComex.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reluco.ReComex.Domain.Data.EscolaMaps
{
    public sealed class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("Contato");

            builder.HasKey(k => k.Id)
                .HasName("ContatoId");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.TipoContato);
            builder.Property(p => p.Valor);

            //Relacionamento 1 x n aluno --> contatos
            builder.HasOne<Aluno>(a => a.Aluno)
                .WithMany(p => p.Contatos)
                .HasForeignKey(a => a.AlunoId);

            //Relacionamento 1 x n colaborador --> contatos
            builder.HasOne<Colaborador>(c => c.Colaborador)
                .WithMany(p => p.Contatos)
                .HasForeignKey(a => a.ColaboradorId);

            //Relacionamento 1 x n colaborador --> contatos
            builder.HasOne<Responsavel>(c => c.Responsavel)
                .WithMany(p => p.Contatos)
                .HasForeignKey(a => a.ResponsavelId);

            builder.Property(p => p.Desabilitado);
            builder.Property(p => p.ModifiedOn);
            builder.Property(p => p.CreatedOn);

           
        }
    }
}
