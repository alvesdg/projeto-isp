namespace Projeto_ISP.Models.PlanosAcao
{
    public class TipoAcao
    {
        public int IdTipoAcao { get; set; } // PK
        public string NomeTipo { get; set; } = string.Empty;

        // Construtor padrão
        public TipoAcao()
        {
        }

        // Construtor com parâmetros
        public TipoAcao(int idTipoAcao, string nomeTipo)
        {
            IdTipoAcao = idTipoAcao;
            NomeTipo = nomeTipo;
        }
    }
}