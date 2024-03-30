using Reluco.ReComex.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reluco.NewSchool.Domain.Entities.Escola
{
    public class Disciplina : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
