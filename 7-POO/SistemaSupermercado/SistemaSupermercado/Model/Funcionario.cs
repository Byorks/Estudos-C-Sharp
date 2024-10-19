using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercado.Models
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public string NumeroRegistro { get; set; }
        public string HorarioTrabalho { get; set; }
       
    }
}
