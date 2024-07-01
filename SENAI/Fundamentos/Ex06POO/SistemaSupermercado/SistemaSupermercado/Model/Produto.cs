using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercado.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        // Float - Limite menor que o Double
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
