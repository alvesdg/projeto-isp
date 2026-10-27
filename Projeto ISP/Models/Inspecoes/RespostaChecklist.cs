namespace Projeto_ISP.Models.Inspecoes
{
    public class RespostaChecklist
    {
        public int IdResposta { get; set; } // PK
        public int IdInspecao { get; set; } // FK
        public int IdPergunta { get; set; } // FK

        public int VersaoPerguntaUsada { get; set; }
        public string RespostaOpcao { get; set; } = string.Empty;
        public string? Observacao { get; set; }

        // Construtor padrão
        public RespostaChecklist()
        {
        }

        // Construtor com parâmetros
        public RespostaChecklist(int idResposta, int idInspecao,
            int idPergunta, int versaoPerguntaUsada,
            string respostaOpcao, string? observacao)
        {
            IdResposta = idResposta;
            IdInspecao = idInspecao;
            IdPergunta = idPergunta;
            VersaoPerguntaUsada = versaoPerguntaUsada;
            RespostaOpcao = respostaOpcao;
            Observacao = observacao;
        }
    }
}