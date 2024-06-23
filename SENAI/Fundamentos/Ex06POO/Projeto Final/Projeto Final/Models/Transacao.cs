using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Models
{
    internal class Transacao
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }
        public int DataTransacao { get; set; }
        public int HoraTransacao { get; set; }
        // Lista dos produtos comprados
        public int ProdutosComprados { get; set; }
        public double ValorTotal { get; set; }


        
        // CRUD para transações de Vendas

    }
}
