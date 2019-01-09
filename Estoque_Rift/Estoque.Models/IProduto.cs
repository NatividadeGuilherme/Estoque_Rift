
using System.Collections.Generic;


namespace Estoque.Models
{
    public interface IProduto
    {
        void CadastrarProduto(Produto produto);
        List<Produto> ObterTodosProdutos();
        Produto ObterProdutoPorId(int Id);
        void AlterarProduto(Produto produto);
        void ExcluirProduto(Produto produto);
    }
}
