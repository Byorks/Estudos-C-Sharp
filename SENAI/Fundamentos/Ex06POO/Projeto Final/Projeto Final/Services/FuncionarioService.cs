using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Services
{
    using Projeto_Final.Models;
    internal class FuncionarioService
    {
        private List<Funcionario> _listaFuncionarios;


        // Método Construtor
        // Serve para iniciarlizar a classe com algumas especificaçoes que eu coloco, no caso, criar uma lista
        public FuncionarioService()
        {
            _listaFuncionarios = new List<Funcionario>();
        }

        private int qtd = 0;

        // Adicionar Funcionário
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionario.Id = qtd++;
            _listaFuncionarios.Add(funcionario);
        }

        // Mostrar detalhes do funcionário
        public List<Funcionario> ListarFuncionarios()
        {
            return _listaFuncionarios;
        }

        public void RemoverFuncionario(Funcionario funcionario)
        {
            _listaFuncionarios.Remove(funcionario);
        }

        public Funcionario BuscarPorId(int id)
        {
            return _listaFuncionarios.FirstOrDefault(i => i.Id == id);

        }
    }
}
