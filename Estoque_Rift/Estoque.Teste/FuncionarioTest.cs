using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Estoque.DAL;
using Estoque.Models;

namespace Estoque.Teste
{
    /// <summary>
    /// Descrição resumida para FuncionarioTest
    /// </summary>
    [TestClass]
    public class FuncionarioTest
    {
        FuncionarioDAL dal = new FuncionarioDAL();
        [TestMethod]
        public void IncluirFuncionario()
        {
            

            var funcionario = new Funcionario()
            {
                Nome = "Eduardo Bastazzini",
                Cpf = "45669435856",
                Email = "eduardo@gmail.com"
            };
            dal.Cadastrar(funcionario);
        }
        [TestMethod]
        public void TestarBusca()
        {
            var listadeFuncionarios = dal.ObterFuncionarios();

            foreach(var funcionario in listadeFuncionarios)
            {
                Console.WriteLine("Nome {0} Cpf {1} E-mail {2}", funcionario.Nome, funcionario.Cpf, funcionario.Email);
            }
        }
    }
}
