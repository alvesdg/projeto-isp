namespace Projeto_ISP.Models.Inspecoes
{
    public class ParticipanteInspecao
    {
        public int IdInspecao { get; set; } // PK composta e FK
        public int IdUsuario { get; set; } // PK composta e FK

        public string FuncaoAcompanhante { get; set; } = string.Empty;



        // Construtor padrão
        public ParticipanteInspecao()
        {
        }

        // Construtor com parâmetros
        public ParticipanteInspecao(int idInspecao, int idUsuario,
            string funcaoAcompanhante)
        {
            IdInspecao = idInspecao;
            IdUsuario = idUsuario;
            FuncaoAcompanhante = funcaoAcompanhante;
        }
    }
}