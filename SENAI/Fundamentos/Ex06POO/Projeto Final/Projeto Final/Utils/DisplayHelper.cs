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
            List<Cliente> listaClientes = clienteService.ListarClientes();
            foreach (Cliente cliente in listaClientes)
            {

            }
        }    
    }
}
