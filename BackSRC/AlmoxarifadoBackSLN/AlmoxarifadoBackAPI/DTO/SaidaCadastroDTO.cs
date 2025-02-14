namespace AlmoxarifadoBackAPI.DTO
{
    public class SaidaCadastroDTO
    {
        public int QuantidadeSaida { get; set; }
        public DateTime DataDeSaida { get; set; }
        public int IdFornecedor { get; set; }
        public int IdSecretaria { get; set; }
    }
}
