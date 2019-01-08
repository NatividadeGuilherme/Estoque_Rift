﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Estoque.DAL;
using Estoque.Models;
using Estoque.BLL;

namespace Estoque.Teste
{
    /// <summary>
    /// Descrição resumida para FuncionarioTestkkee
    /// </summary>
    [TestClass]
    public class FuncionarioTest
    {
        private FuncionarioBLL bll;
        
        public FuncionarioTest()
        {
            var dal = new FuncionarioDAL();
             bll = new FuncionarioBLL(dal);
        }
        [TestMethod]
        public void IncluirFuncionario()
        {
           
            var funcionario = new Funcionario()
            {
                Nome = "Eduardo Bastazzini",
                Cpf = "45669435856",
                Email = "eduardo@gmail.com"
            };
            bll.Cadastrar(funcionario);
        }
        [TestMethod]
        public void TestarBusca()
        {
            var listadeFuncionarios = bll.ObterFuncionarios();

            foreach(var funcionario in listadeFuncionarios)
            {
                Console.WriteLine("Nome {0} Cpf {1} E-mail {2}", funcionario.Nome, funcionario.Cpf, funcionario.Email);
            }
        }
    }
}
