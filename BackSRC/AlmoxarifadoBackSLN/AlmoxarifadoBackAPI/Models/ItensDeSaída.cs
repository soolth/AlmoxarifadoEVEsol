namespace AlmoxarifadoBackAPI.Models
{
    public class ItensDeSaída
    {
        public int IdItensDeSaida { get; set; }
        public int IdProduto { get; set; }
        public int QuantidadeSaida { get; set; }
        public DateTime DataDeSaida { get; set; }
        public int IdISaida { get; set; }
        public int IdFornecedor { get; set; }
    }
}
