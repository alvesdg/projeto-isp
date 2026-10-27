namespace Projeto_ISP.Models.Setores
{
    public class SetorArea
    {
        public int IdArea { get; set; } // PK
        public int IdResponsavelPrincipal { get; set; } // FK

        public string NomeArea { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public bool StatusAtivo { get; set; }

        // Construtor padrão
        public SetorArea()
        {
        }

        // Construtor com parâmetros
        public SetorArea(int idArea, int idResponsavelPrincipal,
            string nomeArea, string descricao, bool statusAtivo)
        {
            IdArea = idArea;
            IdResponsavelPrincipal = idResponsavelPrincipal;
            NomeArea = nomeArea;
            Descricao = descricao;
            StatusAtivo = statusAtivo;
        }
    }
}