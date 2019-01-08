using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Estoque.DAL;
using Estoque.Models;

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

            dal.InclusaoInventario(new Inventario()
            {
                ProdutoId = 1,
                QuantidadeDisponivel = 40,
                QuantidadeMinima = 5
            });
        }
    }
}
