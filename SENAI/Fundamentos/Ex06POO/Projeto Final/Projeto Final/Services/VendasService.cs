using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Final.Models;

namespace Projeto_Final.Services
{
    public class VendasService
    {
        private List<List<Produto>>  _vendasEfetudas;

        public VendasService()
        {
            _vendasEfetudas = new List<List<Produto>>();
        }

        public void AdicionarVendas(List<Produto> listaProd)
        {
           _vendasEfetudas.Add(listaProd);
        }
        
        // Quero a lista que está dentro da lista, identificada pelo Id
        public List<Produto> ProdutosCompradosID(int id)
        {
            return _vendasEfetudas[id];
        }    

        public static void AdicionarItensVenda()
        {

        }

        public List<List<Produto>> ListarVendas()
        {
            return _vendasEfetudas;
        }
    }
}
