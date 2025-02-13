using Microsoft.VisualBasic;

namespace AlmoxarifadoBackAPI.DTO
{
    public class EntradaCadastroDTO
    {
        public int Observacao { get; set; }

        public int IdFornecedor { get; set; }

        public DateTime DataDeEntrada { get; set; }
    }
}
