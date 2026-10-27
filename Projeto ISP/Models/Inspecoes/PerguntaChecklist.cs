namespace Projeto_ISP.Models.Inspecoes
{
    public class PerguntaChecklist
    {
        public int IdPergunta { get; set; } // PK
        public int IdTopico { get; set; } // FK
        public int? IdArea { get; set; } // FK

        public string TextoPergunta { get; set; } = string.Empty;
        public bool Obrigatoria { get; set; }
        public bool PermiteNaoAplicavel { get; set; }
        public int Versao { get; set; }
        public bool StatusAtivo { get; set; }


        // Construtor padrão
        public PerguntaChecklist()
        {

        }


        // Construtor com parâmetros
        public PerguntaChecklist(int idPergunta, int idTopico,
            int? idArea, string textoPergunta, bool obrigatoria,
            bool permiteNaoAplicavel, int versao, bool statusAtivo)
        {
            IdPergunta = idPergunta;
            IdTopico = idTopico;
            IdArea = idArea;
            TextoPergunta = textoPergunta;
            Obrigatoria = obrigatoria;
            PermiteNaoAplicavel = permiteNaoAplicavel;
            Versao = versao;
            StatusAtivo = statusAtivo;
        }
    }
}