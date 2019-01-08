using Dapper;
using Estoque.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Estoque.DAL
{
    public class InventarioDAL : IInventario
    {
        readonly string conexao = ConfigurationManager.ConnectionStrings["RiftConnection"].ConnectionString;
        public void InclusaoInventario(Inventario inventario)
        {
            var conection = new SqlConnection(conexao);
            string sql = @"Insert Into Inventario 
                                       (ProdutoId,QuantidadeDisponivel,QuantidadeMinima) 
                                Values (@ProdutoId,@QuantidadeDisponivel,@QuantidadeMinima)";
            conection.Open();
            conection.Execute(sql, new { @ProdutoId = inventario.ProdutoId, @QuantidadeDisponivel = inventario.QuantidadeDisponivel,
                @QuantidadeMinima = inventario.QuantidadeMinima });
            conection.Close();
        }
    }
}
