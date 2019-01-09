
using System.Collections.Generic;


namespace Estoque.Models
{
    public interface IProduto
    {
        void CadastrarProduto(Produto produto);
        List<Produto> ObterTodosProdutos();
        Produto ObterProduto(int IdProduto);
        void AlterarProduto(Produto produto);
    }
}
