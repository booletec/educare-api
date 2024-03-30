using Educare.Core.Abstractions;
using Educare.Core.Enumerations;

namespace Educare.Core.School.Entities
{
    public class Pessoa : BaseEntity
    {

        public Pessoa()
        {
            Contatos = new HashSet<Contato>();
            Enderecos = new HashSet<Endereco>();
        }
        
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime NascidoEm { get; set; }
        public string Cpf { get; set; }
        public string Identidade { get; set; }
        public Sexo Sexo { get; set; }

        public ICollection<Contato> Contatos { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }

        public string ApplicationUserId { get; set; }
    }
}
