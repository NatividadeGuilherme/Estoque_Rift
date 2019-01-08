using Estoque.Models;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Estoque.DAL
{
    public class FuncionarioDAL : IFuncionario
    {
        readonly string conexao = ConfigurationManager.ConnectionStrings["RiftConnection"].ConnectionString;
        public void Cadastrar(Funcionario funcionario)
        {
            var connection = new SqlConnection(conexao);
            string sql = @"Insert into Funcionario 
                                 (Nome,Cpf,Email)
                           Values(@Nome,@Cpf,@Email)";
            connection.Open();

            connection.Execute(sql, new { @Nome = funcionario.Nome, @Cpf = funcionario.Cpf, @Email = funcionario.Email });

            connection.Close();
        }
        public List<Funcionario> ObterFuncionarios()
        {
            var connection = new SqlConnection(conexao);
            connection.Open();

            var listaDeFuncionarios = connection.Query<Funcionario>("Select * From Funcionario").ToList();
            connection.Close();
            return listaDeFuncionarios;
        }
    }
}
