using Estoque.BLL;
using Estoque.DAL;
using Estoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estoque_Rift.App_Codigo
{
    public class ContainerIInstancias
    {
        public static IInventario ObterBLLInventario()
        {
            var dal = new InventarioDAL();
            var bll = new InventarioBLL(dal);

            return bll;
        }
        //public static IProduto ObterBLLProduto()
        //{
        //    var dal = new ProdutoDAL();
        //   // var bll = new ProdutoBLL();
        //}
    }
}