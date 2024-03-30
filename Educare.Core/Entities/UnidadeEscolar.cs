using System;
using System.Collections.Generic;
using System.Text;

namespace Educare.Core.School.Entities
{
    public class UnidadeEscolar : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Endereco Endereco { get; set; }
      
    }
}
