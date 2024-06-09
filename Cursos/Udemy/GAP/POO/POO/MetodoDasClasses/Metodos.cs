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

        // Passagem de parâmetros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é: " + valor);
        }

        // Passagem de parâmetro por referência 
        // Não mais pegamos o valor emprestado e somamos, agora a variável inserida será alterada com um novo valor ou alteração, não é mais uma copia onde
        // a variável original se mantem inalterada
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por referência) é: " + valor);
        }
        // Métodos com retorno de valores
        // retorno de string, nesse caso
        public string MontaNome( string nome, string sobrenome )
        {
            //string nomeCompleto = nome + " " + sobrenome;
            // Obrigatório ter retorno
            // Para simplificar o código, podemos ir diretamente, sem precisar criar a variável
            // Porque ele já retorna o resultado da expressão
            return nome + " " + sobrenome;
        }

        // O retorno não está ligado ao tipo do parâmetro, e podemos criar métodos sem parametros que retornam tipos variádos
        public int CodigoChar ( char caractere )
        {   // conversão explicita é desnecessária
            //int codigo = (int)caractere;
            // Neste caso já estamos convertendo implícitamente 
            return caractere;
        }
        
        // Criando método que retorna double, mas não tem parámetros
        public double ValorPi()
        {
            return 3.1415;
        }
                 
    }
        
}   
