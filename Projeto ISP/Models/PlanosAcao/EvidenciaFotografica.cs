namespace Projeto_ISP.Models.PlanosAcao
{
    public class EvidenciaFotografica
    {
        public int IdEvidencia { get; set; } // PK
        public int IdNaoConformidade { get; set; } // FK
        public int IdPlanoAcao { get; set; } // FK
        public int IdUsuarioUpload { get; set; } // FK

        public string FaseEvidencia { get; set; } = string.Empty;
        public string UrlCaminhoArquivo { get; set; } = string.Empty;
        public DateTime DataUpload { get; set; }



        // Construtor padrão
        public EvidenciaFotografica()
        {


        }




        // Construtor com parâmetros
        public EvidenciaFotografica(int idEvidencia,
            int idNaoConformidade, int idPlanoAcao,
            int idUsuarioUpload, string faseEvidencia,
            string urlCaminhoArquivo, DateTime dataUpload)
        {
            IdEvidencia = idEvidencia;
            IdNaoConformidade = idNaoConformidade;
            IdPlanoAcao = idPlanoAcao;
            IdUsuarioUpload = idUsuarioUpload;
            FaseEvidencia = faseEvidencia;
            UrlCaminhoArquivo = urlCaminhoArquivo;
            DataUpload = dataUpload;
        }
    }
}