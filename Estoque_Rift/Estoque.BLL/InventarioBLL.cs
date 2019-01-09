using Estoque.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.BLL
{
    public class InventarioBLL : IInventario
    {
        private IInventario _dalInventario;
        public InventarioBLL(IInventario inventario)
        {
            _dalInventario = inventario;
        }
        public void InclusaoInventario(Inventario inventario)
        {
            try
            {
                _dalInventario.InclusaoInventario(inventario);
            }
            catch(Exception ex)
            {
                throw new Exception("Este produto já está adicionado ao inventário");
            }
            
        }

        public List<Inventario> ListaInventario()
        {
            return _dalInventario.ListaInventario();
        }
    }
}
