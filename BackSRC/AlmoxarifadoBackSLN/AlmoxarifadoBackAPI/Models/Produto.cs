namespace AlmoxarifadoBackAPI.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public string UnMedida { get; set; }
        public bool EPermanente { get; set; }
        public double EstoqueAtual { get; set; }
        public double PrecoProduto { get; set; }
        public int IdCategoria { get; set; }
    }
}
