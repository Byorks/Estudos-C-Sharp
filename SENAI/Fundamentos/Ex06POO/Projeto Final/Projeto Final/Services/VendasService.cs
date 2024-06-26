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
        private List<Produto>  _vendasEfetudas;

        public VendasService()
        {
            _vendasEfetudas = new List<Produto>();
        }

        public void AdicionarVendas(Produto produto)
        {
           _vendasEfetudas.Add(produto);
        }

    }
}
