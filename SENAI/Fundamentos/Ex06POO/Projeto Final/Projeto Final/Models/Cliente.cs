using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Models
{
    public class Cliente : Pessoa
    {
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        // Vou pegar esse valor separadamente e depois atribuir aqui!
        public int DataNascimento { get; set; }
    }
}
