using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reluco.ReComex.Domain.Entities.Escola;
using Reluco.ReComex.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reluco.ReComex.Domain.Data.EscolaMaps
{
    public sealed class CargoMap : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("Cargo");

            builder.HasKey(k => k.Id)
                .HasName("CargoId");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Nome);
            builder.Property(p => p.Descricao);                   

            builder.Property(p => p.Desabilitado);
            builder.Property(p => p.ModifiedOn);
            builder.Property(p => p.CreatedOn);

           
        }
    }
}
