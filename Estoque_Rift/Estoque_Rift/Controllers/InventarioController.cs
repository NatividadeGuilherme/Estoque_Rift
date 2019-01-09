
using Estoque.DAL;
using Estoque.Models;
using Estoque_Rift.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Estoque_Rift.Controllers
{
    public class InventarioController : Controller
    {
        private IInventario _bllInventario;
        readonly private IProduto _bllProduto;
        public InventarioController()
        {
            _bllProduto = App_Codigo.ContainerIInstancias.ObterBLLProduto(); 
            var bll = App_Codigo.ContainerIInstancias.ObterBLLInventario();
            _bllInventario = bll;
        }
        // GET: Inventario
        
        public ActionResult Index()
        {
            var listaInventario = _bllInventario.ListaInventario();

            var listaInventarioViewModel = ConverterParaViewModel(listaInventario);
            return View(listaInventarioViewModel);
        }

        public List<InventarioViewModel> ConverterParaViewModel(List<Inventario> listaInventario)
        {
            var listaInventarioViewModel = new List<InventarioViewModel>();

            foreach ( var item in listaInventario)
            {
                listaInventarioViewModel.Add(
                    new InventarioViewModel()
                    {
                        IdInventario = item.Id,
                        QuantidadeDisponivel = item.QuantidadeDisponivel,
                        QuantidadeMinima = item.QuantidadeMinima,
                        NomeProduto = _bllProduto.ObterProdutoPorId(item.ProdutoId).Nome
                    }
                );   
            }
            return listaInventarioViewModel;
        }

    }
}