using System.Collections.Generic;
using Estoque.Models;
namespace Estoque.BLL
{
    public class FuncionarioBLL : IFuncionario
    {
        private IFuncionario _funcionarioDAL;
        public FuncionarioBLL(IFuncionario funcionarioDAL)
        {
            _funcionarioDAL = funcionarioDAL;

        }
        public void Cadastrar(Funcionario funcionario)
        {
            _funcionarioDAL.Cadastrar(funcionario);
        }

        public List<Funcionario> ObterFuncionarios()
        {
            throw new System.NotImplementedException();
        }
    }
}
