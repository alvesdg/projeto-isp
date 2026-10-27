namespace Projeto_ISP.Models.Acesso
{
    public class PerfilAcesso
    {
        public int IdPerfil { get; set; } // PK
        public string NomePerfil { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        // Construtor padrão:
        public PerfilAcesso()
        {
        }


        // Construtor com parâmetros:
        public PerfilAcesso(int idPerfil, string nomePerfil, string descricao)
        {
            IdPerfil = idPerfil;
            NomePerfil = nomePerfil;
            Descricao = descricao;
        }
    }
}