using Projeto_Final.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Final.Models;

namespace Projeto_Final.Utils
{
    internal static class DisplayHelper
    {
        public static void MostrarClientes(ClienteService clienteService)
        {
            // A _listaclientes está sendo recebida pela listaClientes
            List<Cliente> listaClientes = clienteService.ListarClientes();
            // Para cada "cliente" na lista, excutaremos um método, que fará escrever os detalhes na tela
            foreach (Cliente cliente in listaClientes)
            {
                cliente.MostrarDetalhesCliente();
            }
        }    

        public static void MostrarFuncionarios(FuncionarioService funcionarioService)
        {
            List<Funcionario> listaFuncionarios = funcionarioService.ListarFuncionarios();

            foreach ( Funcionario funcionario in listaFuncionarios)
            {
                funcionario.MostrarDetalhes();
            }
        }
    }
}
