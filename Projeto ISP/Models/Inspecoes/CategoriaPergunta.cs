namespace Projeto_ISP.Models.Inspecoes
{
    public class CategoriaPergunta
    {
        public int IdTopico { get; set; } // PK

        public string NomeTopico { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public bool StatusAtivo { get; set; }

        // Construtor padrão
        public CategoriaPergunta()
        {

        }

        // Construtor com parâmetros
        public CategoriaPergunta(
            int idTopico, 
            string nomeTopico,
            string descricao,
            bool statusAtivo)
        {
            IdTopico = idTopico;
            NomeTopico = nomeTopico;
            Descricao = descricao;
            StatusAtivo = statusAtivo;
        }
    }
}