using Microsoft.VisualBasic;

namespace AlmoxarifadoBackAPI.DTO
{
    public class ItensDeEntradaCadastroDTO
    {
        public int IdProduto { get; set; }
        public int IdFornecedor { get; set; }
        public DateTime DataDeEntrada { get; set; }
        public int QuantidadeEntrada { get; set; }
        public int Preco { get; set; }
        public int Total { get; set; }
    }
}
