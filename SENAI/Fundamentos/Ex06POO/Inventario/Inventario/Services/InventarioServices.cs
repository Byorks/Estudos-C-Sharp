using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Services
{
    using Models;

    public class InventarioServices
    {
        // Nome da pasta/classe no plural e métodos no singular, boas práticas

        // Criando lista do tipo objeto Item 
        private List<Item> _itens;
        
        //ctor + tab atalho para montar método construtor
        public InventarioServices()
        {
            // Aqui serve justamente para criar uma lista
            // Se não tivesse isso, precisariamos criar manualmente uma lista
            _itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            // Vai adicionar dentro da lista
            _itens.Add(item);
        }

        // Lendo a lista, só devolver a mesma
        public List<Item> ListarItens()
        {
            return _itens;
        }

        public Item BuscarPorId(int id)
        {   
            // Como se fosse um if dentro de um foreach 
            return _itens.FirstOrDefault(i => i.Id == id);
        }

        // Remover
        // Precisa receber o objeto - item
        public void RemoverItem(Item item)
        {
            _itens.Remove(item);
        }
    }
}
