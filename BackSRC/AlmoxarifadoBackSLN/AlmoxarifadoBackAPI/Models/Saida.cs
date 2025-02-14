namespace AlmoxarifadoBackAPI.Models
{
    public class Saida
    {
        public int IdSaida { get; set; }
        public int QuantidadeSaida { get; set; }
        public DateTime DataDeSaida { get; set; }
        public int IdFornecedor { get; set; }
        public int IdSecretaria { get; set; }
    }
}
