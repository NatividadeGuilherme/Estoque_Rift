using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Models;
namespace Estoque.BLL
{
    public class ProdutoBLL : IProduto
    {
        private IProduto _produtoDAL;
        public ProdutoBLL(IProduto produtoDAL)
        {
            _produtoDAL = produtoDAL;
        }
        public void AlterarProduto(Produto produto)
        {
            _produtoDAL.AlterarProduto(produto);
        }

        public void CadastrarProduto(Produto produto)
        {
            _produtoDAL.CadastrarProduto(produto);
        }

        public void ExcluirProduto(Produto produto)
        {
            _produtoDAL.ExcluirProduto(produto);
        }

        public Produto ObterProdutoPorId(int Id)
        {
           return _produtoDAL.ObterProdutoPorId(Id);
        }

        public List<Produto> ObterTodosProdutos()
        {
            return _produtoDAL.ObterTodosProdutos();
        }
    }
}
