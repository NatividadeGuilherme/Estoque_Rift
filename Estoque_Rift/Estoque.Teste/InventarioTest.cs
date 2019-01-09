using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Estoque.DAL;
using Estoque.Models;
using Estoque.BLL;

namespace Estoque.Teste
{
    /// <summary>
    /// Descrição resumida para InventarioTest
    /// </summary>
    [TestClass]
    public class InventarioTest
    {
        [TestMethod]
        public void InserirItemInventario()
        {
            var dal = new InventarioDAL();
            var bll = new InventarioBLL(dal);

            bll.InclusaoInventario(new Inventario()
            {
                ProdutoId = 1,
                QuantidadeDisponivel = 50,
                QuantidadeMinima = 10
            });

        }
    }
}
