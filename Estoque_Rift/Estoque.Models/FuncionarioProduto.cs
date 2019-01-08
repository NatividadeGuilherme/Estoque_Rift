using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Models
{
    public class FuncionarioProduto
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public int ProdutoId { get; set; }
        public Funcionario Funcionario { get; set; }
        public Produto Produto { get; set; }
    }
}
