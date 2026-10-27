namespace Projeto_ISP.Models.Inspecoes
{
    public class InspecaoIsp
    {
        public int IdInspecao { get; set; } // PK
        public int IdArea { get; set; } // FK
        public int IdResponsavelInspecao { get; set; } // FK

        public DateTime DataHoraInicio { get; set; }
        public DateTime? DataHoraFim { get; set; }
        public string SemanaOperacional { get; set; } = string.Empty;
        public string StatusInspecao { get; set; } = string.Empty;


        // Construtor padrão
        public InspecaoIsp()
        {

        }


        // Construtor com parâmetros
        public InspecaoIsp(int idInspecao, int idArea,
            int idResponsavelInspecao, DateTime dataHoraInicio,
            DateTime? dataHoraFim, string semanaOperacional,
            string statusInspecao)
        {
            IdInspecao = idInspecao;
            IdArea = idArea;
            IdResponsavelInspecao = idResponsavelInspecao;
            DataHoraInicio = dataHoraInicio;
            DataHoraFim = dataHoraFim;
            SemanaOperacional = semanaOperacional;
            StatusInspecao = statusInspecao;
        }
    }
}