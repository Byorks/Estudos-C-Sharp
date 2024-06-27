using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Método_Construtor
{
    internal class Pessoa
    {
        public string Nome;
        public string Sobrenome;
        public int AnoNascimento;
        public int Idade;

        // Método construtor
        // Sempre public e usa o nome da classe
        public Pessoa()
        {   
            // Assim que o objeto é instanciado, ele chama o método construtor
            Nome = "Desconhecido";
            Sobrenome = "Nehum";
            AnoNascimento = 0;
            Idade = 0;  
        }
    }
}
