using Projeto_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Services
{
    public class CarrinhoService
    {
        // Criar uma lista produtos comprados/selecionados
        private List<Produto> _produtosCarrinho;
        public CarrinhoService()
        {
            _produtosCarrinho = new List<Produto>();
        }

        // Add - Quando for adicionar, vai pegar a hora atual
        public void AdicionarCarrinho(Produto produto)
        {
            _produtosCarrinho.Add(produto);
        }
        // Listar
        public List<Produto> ListarCarrinho()
        {
            return _produtosCarrinho;
        }

        // Deletar
        public void RemoverProduto(Produto produto)
        {
            _produtosCarrinho.Remove(produto);
        }

        // BuscarPorID

        public Produto BuscarPorID(int id)
        {
            return _produtosCarrinho.FirstOrDefault(x => x.Id == id);
        }


    }
    
}
