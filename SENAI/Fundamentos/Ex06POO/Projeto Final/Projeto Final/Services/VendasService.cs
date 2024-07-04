using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Final.Models;
using Projeto_Final.Services;


namespace Projeto_Final.Services
{
    public class VendasService
    {
        private List<List<Produto>> _produtosVendidos;

        public VendasService()
        {
            _produtosVendidos = new List<List<Produto>>();
        }

        public void AdicionarVendas(List<Produto> listaProd)
        {
            _produtosVendidos.Add(listaProd);
        }

        public void AdicionarVendasPosicao(List<Produto> listaProd, int idPos)
        {
            _produtosVendidos.Insert(idPos, listaProd);
        }

        // Quero a lista que está dentro da lista, identificada pelo Id
        public List<Produto> ProdutosCompradosID(int id)
        {
            return _produtosVendidos[id];
        }

        public List<List<Produto>> ListarVendas()
        {
            return _produtosVendidos;
        }

        public void RemoverVendas(List<Produto> listaProd)
        {
            _produtosVendidos.Remove(listaProd);
        }
    }
}
