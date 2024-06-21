using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Models
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public int NumeroRegistro { get; set; }
        public double HorarioTrabalho { get; set; }
    }
}
