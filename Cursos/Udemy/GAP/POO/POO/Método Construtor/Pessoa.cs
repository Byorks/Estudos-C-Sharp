using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Método_Construtor
{
    public class Pessoa
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

        // Método Construtor com Overload   
        public Pessoa(string nome, string sobrenome,int anoNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            AnoNascimento = anoNascimento;
            Idade = IdadeCalc();
        }        
        
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            AnoNascimento = 2000;
            Idade = IdadeCalc();
        }

        private int IdadeCalc()
        {
            return DateTime.Now.Year - AnoNascimento;
        }
    }
}
