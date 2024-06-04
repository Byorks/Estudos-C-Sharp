using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDasClasses
{
    internal class Metodos
    {
        // Método Simples 
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo(a).");
        }

        // Métodos com Parâmetros
        // Pode ter retorno
        // Dentro dos () entrará os parametros, ficarão visiveis apenas dentro do escopo
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
        }

        public void Apresentar (string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos");
        }
    }
}
