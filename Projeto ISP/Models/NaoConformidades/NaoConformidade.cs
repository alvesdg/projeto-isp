namespace Projeto_ISP.Models.NaoConformidades
{
    public class NaoConformidade
    {
        public int IdNaoConformidade { get; set; } // PK
        public int IdResposta { get; set; } // FK
        public int? IdNcRecorrenteOrigem { get; set; } // FK

        public string DescricaoDetalhada { get; set; } = string.Empty;
        public string ClassificacaoRisco { get; set; } = string.Empty;
        public string StatusNc { get; set; } = string.Empty;



        // Construtor padrão
        public NaoConformidade()
        {
        }



        // Construtor com parâmetros
        public NaoConformidade(int idNaoConformidade,
            int idResposta, int? idNcRecorrenteOrigem,
            string descricaoDetalhada, string classificacaoRisco,
            string statusNc)
        {
            IdNaoConformidade = idNaoConformidade;
            IdResposta = idResposta;
            IdNcRecorrenteOrigem = idNcRecorrenteOrigem;
            DescricaoDetalhada = descricaoDetalhada;
            ClassificacaoRisco = classificacaoRisco;
            StatusNc = statusNc;
        }
    }
}