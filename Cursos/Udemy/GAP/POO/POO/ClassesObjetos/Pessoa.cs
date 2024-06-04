using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {   
        // Atributos / Campos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        // Definindo Método Simples
        // Realiza função mas não tem retorno de valor ou não recebe valores
        // primeiro é o modificador de acesso => public, torna acessível para todos os objetos derivados dessa classe
        // depois o retorno => void, simples e vázio 
        public void Cumprimentar()
        {
            Console.WriteLine("Olá eu sou " + nome + " " + sobrenome + " prazer!");

        }
    }
}
