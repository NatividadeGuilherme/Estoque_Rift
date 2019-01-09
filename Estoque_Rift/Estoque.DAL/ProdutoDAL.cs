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
            throw new NotImplementedException();
        }

        public void CadastrarProduto(Produto produto)
        {
            var conecction = new SqlConnection(conexao);
            string sql = @"Insert Into Produto
                                Values (@Nome)";
            conecction.Open();
            conecction.Execute(sql, new { Nome = produto.Nome });
            conecction.Close();
        }

        public Produto ObterProduto(int IdProduto)
        {
            var conecction = new SqlConnection(conexao);
            string sql = @"Select * From 
                                         Produto 
                                   Where Id=@IdProduto";
            conecction.Open();
            var produto = conecction.Query<Produto>(sql, new { @IdProduto = IdProduto }).FirstOrDefault();
            conecction.Close();
            return produto;
        }

        public List<Produto> ObterTodosProdutos()
        {
            throw new NotImplementedException();
        }
    }
}
