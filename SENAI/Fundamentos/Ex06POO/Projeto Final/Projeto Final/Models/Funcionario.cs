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
        public string NumeroRegistro { get; set; }
        public double HorarioTrabalho { get; set; }

        public static Funcionario CriarFuncionario()
        {   
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Criação Funcionário");

            Console.WriteLine("Insira o nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Insira o cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.WriteLine("Insira o número de registro do funcionário: ");
            funcionario.NumeroRegistro = Console.ReadLine();

            Console.WriteLine("Insira o horário de trabalho: ");
            funcionario.HorarioTrabalho = Convert.ToDouble(Console.ReadLine());

            return funcionario;
        }
    }
}
