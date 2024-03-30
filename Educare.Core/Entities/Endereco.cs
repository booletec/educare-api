namespace Educare.Core.School.Entities
{
    public class Endereco : BaseEntity
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }


        public int? ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }

        public int? ResponsavelId { get; set; }
        public Responsavel Responsavel { get; set; }

        public int? AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public int? UnidadeEscolarId { get; set; }
        public UnidadeEscolar UnidadeEscolar { get; set; }
    }
}