using Reluco.NewSchool.Common.Contracts.Enumeradores;
using Reluco.ReComex.Domain.Entities;
using System;

namespace Reluco.NewSchool.Domain.Entities.Escola
{
    public class Evento : BaseEntity
    {
        public string Titulo { get; set; }
        public DateTimeOffset Inicio { get; set; }
        public DateTimeOffset? Fim { get; set; }
        public string Descricao { get; set; }
        public StatusEvento Status { get; set;  }

        public DateTimeOffset? DataCancelamento { get; set; }
        public DateTimeOffset? DataPublicacao { get; set; }
        public string Motivo { get; set; }
        public TipoEvento TipoEvento { get; set; }
        public string Local { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

    }
}
