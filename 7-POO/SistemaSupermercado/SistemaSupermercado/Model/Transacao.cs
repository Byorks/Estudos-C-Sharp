using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercado.Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdFuncionario { get; set; }
        public DateTime DataTransacao { get; set; }
        public List<Produto> Produtos { get; set; }
        public double ValorTotal { get; set; }
    }
}
