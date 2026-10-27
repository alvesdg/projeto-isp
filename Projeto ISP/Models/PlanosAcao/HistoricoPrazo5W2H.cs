namespace Projeto_ISP.Models.PlanosAcao
{
    public class HistoricoPrazo5W2H
    {
        public int IdHistoricoPrazo { get; set; } // PK
        public int IdPlanoAcao { get; set; } // FK
        public int IdSolicitante { get; set; } // FK
        public int IdAprovadorSsma { get; set; } // FK

        public DateTime PrazoAnterior { get; set; }
        public DateTime NovoPrazoSolicitado { get; set; }
        public string JustificativaAlteracao { get; set; } = string.Empty;
        public string StatusSolicitacao { get; set; } = string.Empty;
        public DateTime DataSolicitacao { get; set; }



        // Construtor padrão
        public HistoricoPrazo5W2H()
        {


        }



        // Construtor com parâmetros
        public HistoricoPrazo5W2H(int idHistoricoPrazo,
            int idPlanoAcao, int idSolicitante,
            int idAprovadorSsma, DateTime prazoAnterior,
            DateTime novoPrazoSolicitado,
            string justificativaAlteracao,
            string statusSolicitacao, DateTime dataSolicitacao)
        {
            IdHistoricoPrazo = idHistoricoPrazo;
            IdPlanoAcao = idPlanoAcao;
            IdSolicitante = idSolicitante;
            IdAprovadorSsma = idAprovadorSsma;
            PrazoAnterior = prazoAnterior;
            NovoPrazoSolicitado = novoPrazoSolicitado;
            JustificativaAlteracao = justificativaAlteracao;
            StatusSolicitacao = statusSolicitacao;
            DataSolicitacao = dataSolicitacao;
        }
    }
}