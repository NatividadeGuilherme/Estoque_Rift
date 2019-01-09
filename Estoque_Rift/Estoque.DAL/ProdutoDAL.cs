using Estoque.Models;
using System;
using System.Collections.Generic;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace Estoque.DAL
{
    public class ProdutoDAL : IProduto
    {
        readonly string conexao = ConfigurationManager.ConnectionStrings["RiftConnection"].ConnectionString;

        public void AlterarProduto(Produto produto)
        {
            var conecction = new SqlConnection(conexao);
            string sql = @"UPDATE Produto
                              SET Nome
                                = @Nome
                            WHERE Id
                                = @Id";
            conecction.Open();
            conecction.Execute(sql, new { Nome = produto.Nome, Id = produto.Id });
            conecction.Close();
        }

        public void CadastrarProduto(Produto produto)
        {
            var conecction = new SqlConnection(conexao);
            string sql = @"Insert Into Produto
                                        (Nome)
                                Values (@Nome)";
            conecction.Open();
            conecction.Execute(sql, new { @Nome = produto.Nome });
            conecction.Close();
        }

        public void ExcluirProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto ObterProdutoPorId(int IdProduto)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ObterTodosProdutos()
        {
            var connection = new SqlConnection(conexao);
            connection.Open();

            var listaDeProdutos = connection.Query<Produto>("Select * From Produto").ToList();
            connection.Close();
            return listaDeProdutos;
        }
    }
}
