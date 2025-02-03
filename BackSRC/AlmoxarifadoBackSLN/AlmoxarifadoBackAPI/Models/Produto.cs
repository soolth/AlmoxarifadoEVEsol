namespace AlmoxarifadoBackAPI.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public string UnMedida { get; set; }
        public int EPermanente { get; set; }
        public int EstoqueAtual { get; set; }
        public double PrecoProduto { get; set; }
        public int IdCategoria { get; set; }
    }
}
