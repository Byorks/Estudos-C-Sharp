using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Services
{
    using Models;
    public class ClienteService
    {
        // ClienteService gerencia a lita de clientes

        // Criando lista do Tipo Clientes com nome _clientes
        private List<Cliente> _clientes;

        private int qtd = 0;
        public ClienteService()
        {
            _clientes = new List<Cliente>();
        }

        // Criando Cliente
        public void AdicionarCliente(Cliente cliente)
        {
            cliente.Id = qtd++;
            _clientes.Add(cliente);
        }
        // Listando Clientes
        public List<Cliente> ListarClientes()
        {
            return _clientes;
        }

        // Deletando CLiente
        public void RemoverCliente(Cliente cliente)
        {
            _clientes.Remove(cliente);
        }

        public Cliente BuscarPorId(int id)
        {   
            // Método que vai procurar o primeiro a corresponder ao valor inserido no parametro, se não localizar o Id retorna null
            return _clientes.FirstOrDefault(i => i.Id == id);
        }
    }
}
