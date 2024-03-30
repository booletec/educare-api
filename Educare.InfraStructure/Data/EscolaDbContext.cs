using Microsoft.EntityFrameworkCore;
using Reluco.ReComex.Domain.Data.EscolaMaps;
using System.Linq.Expressions;

namespace Reluco.Siscomex.Application.Data
{
    public class EscolaDbContext : DbContext
    {
        public EscolaDbContext(DbContextOptions<EscolaDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.HasDefaultSchema("SchoolPlanning");
            
            builder.ApplyConfiguration(new AlunoMap());
            builder.ApplyConfiguration(new AlunoResponsavelMap());
            builder.ApplyConfiguration(new CargoMap());
            builder.ApplyConfiguration(new ColaboradorMap());
            builder.ApplyConfiguration(new ContatoMap());

            builder.ApplyConfiguration(new ContratoMap());

            builder.ApplyConfiguration(new EnderecoMap());

            builder.ApplyConfiguration(new ResponsavelMap());
            builder.ApplyConfiguration(new TurmaMap());
            builder.ApplyConfiguration(new UnidadeEscolarMap());

            builder.ApplyConfiguration(new DiarioBordoMap());
            builder.ApplyConfiguration(new AssiduidadeMap());
            builder.ApplyConfiguration(new EventoMap());



            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                // 1. Add the IsDeleted property
                entityType.FindProperty("Desabilitado");

                // 2. Create the query filter

                var parameter = Expression.Parameter(entityType.ClrType);

                // EF.Property<bool>(post, "Desabilitado")
                var propertyMethodInfo = typeof(EF).GetMethod("Property").MakeGenericMethod(typeof(bool));
                var ativoProperty = Expression.Call(propertyMethodInfo, parameter, Expression.Constant("Desabilitado"));

                // EF.Property<bool>(post, "Desabilitado") == false
                BinaryExpression compareExpression = Expression.MakeBinary(ExpressionType.Equal, ativoProperty, Expression.Constant(false));

                // post => EF.Property<bool>(post, "Desabilitado") == false
                var lambda = Expression.Lambda(compareExpression, parameter);

                builder.Entity(entityType.ClrType).HasQueryFilter(lambda);
            }
        }

       
       
    }
}
