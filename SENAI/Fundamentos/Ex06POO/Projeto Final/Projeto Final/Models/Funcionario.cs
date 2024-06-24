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
        public string HorarioTrabalho { get; set; }

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
            funcionario.HorarioTrabalho = Console.ReadLine();

            return funcionario;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"ID: {Id}, Nome: {Nome}, Cargo: {Cargo}, Num. Registro: {NumeroRegistro}, Jornada de trabalho: {HorarioTrabalho}");
        }

        public override void Atualizar()
        {
            Console.WriteLine("Atualização Funcionário");

            Console.WriteLine("Insira o novo nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Insira o novo cargo: ");
            Cargo = Console.ReadLine();

            Console.WriteLine("Insira o novo número de registro do funcionário: ");
            NumeroRegistro = Console.ReadLine();

            Console.WriteLine("Insira o novo horário de trabalho: ");
            HorarioTrabalho = Console.ReadLine();
        }
    }
}
