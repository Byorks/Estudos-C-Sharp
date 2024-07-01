using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercado.Models
{
    public class Cliente : Pessoa
    {
        public DateTime DataNascimento {  get; set; }
        public string Endereco {  get; set; }
        public string NumeroTelefone { get; set; }
    }
}
