using Reluco.NewSchool.Common.Contracts.Enumeradores;

namespace Educare.Core.School.Entities
{
    public class Contato : BaseEntity
    {
        /// <summary>
        /// Tipo do contato pode ser telefone, email, celular
        /// </summary>
        public TipoContato TipoContato{ get; set; }

        /// <summary>
        /// Valor dependendo do tipo do contato um valor será atribuido. 
        //  Exemplo: se for um email então vai ser algumacoisa@dominio.com
        /// </summary>
        public string Valor { get; set; }


        //Relacionamentos com Alunos
        public int? AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        //Relacionamentos com Colaborador
        public int? ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }

        //Relacionamentos com Responsavel
        public int? ResponsavelId { get; set; }
        public Responsavel Responsavel { get; set; }


    }

   
}
