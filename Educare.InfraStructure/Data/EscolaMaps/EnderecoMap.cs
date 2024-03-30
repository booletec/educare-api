using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reluco.ReComex.Domain.Entities.Escola;
using Reluco.ReComex.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reluco.ReComex.Domain.Data.EscolaMaps
{
    public sealed class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(k => k.Id)
                .HasName("EnderecoId");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Logradouro);
            builder.Property(p => p.Cep);
            builder.Property(p => p.Complemento);        
            builder.Property(p => p.Bairro);
            builder.Property(p => p.Cidade);
            builder.Property(p => p.Estado);
            builder.Property(p => p.Latitude);
            builder.Property(p => p.Longitude);

            //Relacionamento 1 x n colaborador --> contatos
            builder.HasOne<Aluno>(c => c.Aluno)
                .WithMany(p => p.Enderecos)
                .HasForeignKey(a => a.AlunoId);

            //Relacionamento 1 x n colaborador --> contatos
            builder.HasOne<Colaborador>(c => c.Colaborador)
                .WithMany(p => p.Enderecos)
                .HasForeignKey(a => a.ColaboradorId);

            //Relacionamento 1 x n responsavel --> contatos
            builder.HasOne<Responsavel>(c => c.Responsavel)
                .WithMany(p => p.Enderecos)
                .HasForeignKey(a => a.ResponsavelId);

            builder.Property(p => p.Desabilitado);
            builder.Property(p => p.ModifiedOn);
            builder.Property(p => p.CreatedOn);

           
        }
    }
}
