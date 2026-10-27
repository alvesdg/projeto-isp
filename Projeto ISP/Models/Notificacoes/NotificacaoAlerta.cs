namespace Projeto_ISP.Models.Notificacoes
{
    public class NotificacaoAlerta
    {
        public int IdNotificacao { get; set; } // PK
        public int IdUsuarioDestinatario { get; set; } // FK
        public int IdPlanoAcao { get; set; } // FK
        public int IdInspecao { get; set; } // FK

        public string TipoNotificacao { get; set; } = string.Empty;
        public string Mensagem { get; set; } = string.Empty;
        public DateTime DataEnvio { get; set; }
        public bool EscalonadoGestor { get; set; }



        // Construtor padrão
        public NotificacaoAlerta()
        {


        }




        // Construtor com parâmetros
        public NotificacaoAlerta(int idNotificacao,
            int idUsuarioDestinatario, int idPlanoAcao,
            int idInspecao, string tipoNotificacao,
            string mensagem, DateTime dataEnvio,
            bool escalonadoGestor)
        {
            IdNotificacao = idNotificacao;
            IdUsuarioDestinatario = idUsuarioDestinatario;
            IdPlanoAcao = idPlanoAcao;
            IdInspecao = idInspecao;
            TipoNotificacao = tipoNotificacao;
            Mensagem = mensagem;
            DataEnvio = dataEnvio;
            EscalonadoGestor = escalonadoGestor;
        }
    }
}