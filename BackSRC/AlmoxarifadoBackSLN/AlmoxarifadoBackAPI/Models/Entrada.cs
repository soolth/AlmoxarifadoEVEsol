using Microsoft.VisualBasic;

namespace AlmoxarifadoBackAPI.Models
{
    public class Entrada
    {
        public int IdEntrada { get; set; }

        public int QuantidadeEntrada { get; set; }

        public int IdFornecedor { get; set; }

        public DateAndTime DataDeEntrada { get; set; }
    }
}
