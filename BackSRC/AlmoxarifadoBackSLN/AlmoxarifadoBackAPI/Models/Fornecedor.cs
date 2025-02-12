namespace AlmoxarifadoBackAPI.Models
{
    public class Fornecedor
    {
        public int CodigoF { get; set; }
        public string NomeFornecedor { get; set; }
        public string EnderecoFornecedor { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string EstadoSigla { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }

    }
}
