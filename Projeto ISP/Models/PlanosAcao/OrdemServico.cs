namespace Projeto_ISP.Models.PlanosAcao
{
    public class OrdemServicoOs
    {
        public int IdOrdemServico { get; set; } // PK
        public int IdPlanoAcao { get; set; } // FK

        public string NumeroOsCorporativa { get; set; } = string.Empty;
        public string StatusOs { get; set; } = string.Empty;
        public DateTime DataAbertura { get; set; }

        // Construtor padrão
        public OrdemServicoOs()
        {
        }

        // Construtor com parâmetros
        public OrdemServicoOs(int idOrdemServico, int idPlanoAcao,
            string numeroOsCorporativa, string statusOs,
            DateTime dataAbertura)
        {
            IdOrdemServico = idOrdemServico;
            IdPlanoAcao = idPlanoAcao;
            NumeroOsCorporativa = numeroOsCorporativa;
            StatusOs = statusOs;
            DataAbertura = dataAbertura;
        }
    }
}