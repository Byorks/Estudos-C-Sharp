using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Final.Services;

namespace Projeto_Final.Models
{
    public class Cliente : Pessoa
    {
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        // Vou pegar esse valor separadamente e depois atribuir aqui!
        public int DiaNascimento { get; set; }
        public int MesNascimento { get; set; }
        public int AnoNascimento { get; set; }
        public string CPF { get; set; }

        static public Cliente CriarCliente()
        {
            Cliente cliente = new Cliente();


            Console.WriteLine(" Criação de Cliente");

            Console.WriteLine("Digite o nome: ");
            cliente.Nome = Console.ReadLine();


            Console.WriteLine("Digite o CPF(Apenas números): ");
            cliente.CPF = Console.ReadLine();

            string[] dataNascimento = new string[3];
            Console.WriteLine("Digite sua data de nascimento separado por / :");
            dataNascimento = Console.ReadLine().Split('/');
            cliente.DiaNascimento = int.Parse(dataNascimento[0]);
            cliente.MesNascimento = int.Parse(dataNascimento[1]);
            cliente.AnoNascimento = int.Parse(dataNascimento[2]);

            Console.WriteLine("Informe o endereço: ");
            cliente.Endereco = Console.ReadLine();

            Console.WriteLine("Informe um número de telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.ReadKey();
            return cliente;
        }

        public void MostrarDetalhesCliente()
        {
            Console.WriteLine($"ID: {Id}");
        }

    }
}
