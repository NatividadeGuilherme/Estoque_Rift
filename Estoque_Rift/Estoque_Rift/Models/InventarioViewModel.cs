using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estoque_Rift.Models
{
    public class InventarioViewModel
    {
        public int IdInventario { get; set; }
        public string NomeProduto { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public int QuantidadeMinima { get; set; }
        public int IdProduto { get; set; }

    }
}