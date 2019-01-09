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
                Nome = "Coca-Cola"
            };
            bll.CadastrarProduto(produto);
        }
    }
}
