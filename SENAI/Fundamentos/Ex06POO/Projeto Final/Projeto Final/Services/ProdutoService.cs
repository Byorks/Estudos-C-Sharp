using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Final.Models;

namespace Projeto_Final.Services
{
    internal class ProdutoService
    {
        private List<Produto> _produtos;

        public ProdutoService() {

            _produtos = new List<Produto>();
        }

        int qtd = 0;
        // Add
        public void AdicionarProduto(Produto produto)
        {
            produto.Id = qtd++;
            _produtos.Add(produto);
        }
        // Read
        public List<Produto> ListarProdutos()
        {
            return _produtos;
        }
        // Remove
        public void RemoverProduto(Produto produto)
        {
            _produtos.Remove(produto);
        }

        // SearchForId
        public Produto BuscarPorId(int id)
        {
            return _produtos.FirstOrDefault(i => i.Id == id);
        }


    }
}
