namespace Projeto_ISP.Models.PlanosAcao
{
    public class PlanoAcao5W2H
    {
        public int IdPlanoAcao { get; set; } // PK
        public int IdNaoConformidade { get; set; } // FK
        public int IdTipoAcao { get; set; } // FK
        public int IdResponsavelAcao { get; set; } // FK

        public string OQueWhat { get; set; } = string.Empty;
        public string PorQueWhy { get; set; } = string.Empty;
        public string OndeWhere { get; set; } = string.Empty;
        public DateTime PrazoWhen { get; set; }
        public string ComoHow { get; set; } = string.Empty;
        public decimal QuantoCustaHowMuch { get; set; }
        public string StatusAcao { get; set; } = string.Empty;
        public DateTime? DataConclusaoEfetiva { get; set; }





        // Construtor padrão
        public PlanoAcao5W2H()
        {

        }




        // Construtor com parâmetros
        public PlanoAcao5W2H(int idPlanoAcao,
            int idNaoConformidade, int idTipoAcao,
            int idResponsavelAcao, string oQueWhat,
            string porQueWhy, string ondeWhere,
            DateTime prazoWhen, string comoHow,
            decimal quantoCustaHowMuch, string statusAcao,
            DateTime? dataConclusaoEfetiva)
        {
            IdPlanoAcao = idPlanoAcao;
            IdNaoConformidade = idNaoConformidade;
            IdTipoAcao = idTipoAcao;
            IdResponsavelAcao = idResponsavelAcao;
            OQueWhat = oQueWhat;
            PorQueWhy = porQueWhy;
            OndeWhere = ondeWhere;
            PrazoWhen = prazoWhen;
            ComoHow = comoHow;
            QuantoCustaHowMuch = quantoCustaHowMuch;
            StatusAcao = statusAcao;
            DataConclusaoEfetiva = dataConclusaoEfetiva;
        }
    }
}