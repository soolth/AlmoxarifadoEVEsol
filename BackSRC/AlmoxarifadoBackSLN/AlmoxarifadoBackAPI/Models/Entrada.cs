﻿using Microsoft.VisualBasic;

namespace AlmoxarifadoBackAPI.Models
{
    public class Entrada
    {
        public int IdEntrada { get; set; }

        public int Observacao { get; set; }

        public int IdFornecedor { get; set; }

        public DateTime DataDeEntrada { get; set; }
    }
}
