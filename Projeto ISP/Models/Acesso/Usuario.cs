namespace Projeto_ISP.Models.Acesso
{
    public class Usuario
    {
        public int IdUsuario { get; set; } // PK
        public int IdPerfil { get; set; } // FK
        public int? IdGestorImediato { get; set; } // FK

        public string Nome { get; set; } = string.Empty;
        public string EmailCorporativo { get; set; } = string.Empty;
        public string MicrosoftAuthId { get; set; } = string.Empty;
        public bool StatusAtivo { get; set; }


        // Construtor padrão:
        public Usuario()
        {
        }

        // Construtor com parâmetros:
        public Usuario(
            int idUsuario,
            int idPerfil,
            int? idGestorImediato,
            string nome,
            string emailCorporativo,
            string microsoftAuthId,
            bool statusAtivo)
        {
            IdUsuario = idUsuario;
            IdPerfil = idPerfil;
            IdGestorImediato = idGestorImediato;
            Nome = nome;
            EmailCorporativo = emailCorporativo;
            MicrosoftAuthId = microsoftAuthId;
            StatusAtivo = statusAtivo;
        }
    }
}