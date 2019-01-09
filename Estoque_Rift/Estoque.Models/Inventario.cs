using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Models
{
    public class Inventario
    {
        public int Id {get; set; }
        public int ProdutoId {get; set; }
        public int QuantidadeDisponivel {get; set; }
        public int QuantidadeMinima {get; set; }
        
    }
}
