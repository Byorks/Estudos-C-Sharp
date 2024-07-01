using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaSupermercado.Models;
using SistemaSupermercado.Utils;

namespace SistemaSupermercado.Service
{
    public class ProdutoService
    {
        // Não é mais null porque foi instanciada
        List<Produto> produtos;
        int id = 1;

        public ProdutoService() 
        { 
            produtos = new ();
        }

        public void Cadastrar(Produto prod)
        {
            prod.Id = id;
            produtos.Add(prod);
            // Definição i = id + 1;
            id++;
        }

        public void Listar() 
        {   foreach (var p in produtos)
            {
                DisplayHelper.ExibirProduto(p);
            }
        }
    }
}
