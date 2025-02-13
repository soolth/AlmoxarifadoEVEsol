namespace AlmoxarifadoBackAPI.Models
{
    public class ItensDeEntrada
    {
        public int IdItensDeEntrada { get; set; }
        public int IdProduto { get; set; }
        public int IdFornecedor { get; set; }
        public int DataDeEntrada { get; set; }
        public int QuantidadeEntrada { get; set; }
        public int Preco { get; set; }
        public int Total { get; set; }
    }
}
