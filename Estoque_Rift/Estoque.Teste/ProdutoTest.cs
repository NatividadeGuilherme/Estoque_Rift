using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Models;
using Estoque.DAL;
using Estoque.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Estoque.Teste
{
    [TestClass]
    public class ProdutoTest
    {
        private ProdutoBLL bll;

        public ProdutoTest()
        {
            var dal = new ProdutoDAL();
            bll = new ProdutoBLL(dal);
        }

        [TestMethod]
        public void AdicionaProduto()
        {
            var produto = new Produto()
            {
                Nome = "Sukita Guaraná"
            };
            bll.CadastrarProduto(produto);
        }

        [TestMethod]
        public void AlterarProduto()
        {
            var produto = new Produto()
            {
                Id = 1,
                Nome = "Fanta Uva"
            };
            bll.AlterarProduto(produto);
        }

        [TestMethod]
        public void ExcluirProduto()
        {
            var produto = new Produto()
            {
                Id = 1
            };
            bll.ExcluirProduto(produto);
        }

        [TestMethod]
        public void ObterProdutos()
        {
            var produto = bll.ObterTodosProdutos();
            foreach(var euTentei in produto)
            {
                Console.WriteLine("Produto disponível: {0}", euTentei.Nome);
              
            }
          
        }
    }
}
