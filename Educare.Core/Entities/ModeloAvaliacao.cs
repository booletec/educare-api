using Reluco.NewSchool.Common.Contracts.Enumeradores;
using Reluco.ReComex.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reluco.NewSchool.Domain.Entities.Escola
{
    public class ModeloAvaliacao : BaseEntity
    {
        public string Nome { get; set; }
        public double PontuacaoMaxima { get; set; }
        public TipoEnsino TipoEnsino { get; set; }
        public TipoPeriodo TipoPeriodo { get; set; }

    }
}
