using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    delegate void Operacao(int num1, int num2);

    public class Matematica
    {
        public void Somar(int num1, int num2)
        {
            Console.WriteLine("A soma é: " + (num1 + num2));
        }   
        public void Subtrair(int num1, int num2)
        {
            Console.WriteLine("A subtração é: " + (num1 - num2));
        }
        public void Multiplicar(int num1, int num2)
        {
            Console.WriteLine("A multiplicação é: " + (num1 * num2));
        } 
        public void Dividir(int num1, int num2)
        {
            Console.WriteLine("A divisão é: " + (num1 / num2));
        }
    }
}
