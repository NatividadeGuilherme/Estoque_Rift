using System;

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
        public ActionResult Incluir()
        {
            ViewBag.Produtos = _bllProduto.ObterTodosProdutos();

            return View();

        }
        [HttpPost]
        public ActionResult Incluir(InventarioViewModel inventario)
        {
            try
            {
                var inventarioModel = ConverterParaModel(inventario);
                _bllInventario.InclusaoInventario(inventarioModel);

                return RedirectToAction("Index");
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Inventario ConverterParaModel(InventarioViewModel inventario)
        {
            var inventarioModel = new Inventario()
            {
                Id = inventario.IdInventario,
                ProdutoId = inventario.IdProduto,
                QuantidadeDisponivel = inventario.QuantidadeDisponivel,
                QuantidadeMinima = inventario.QuantidadeMinima
            };
            return inventarioModel;
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