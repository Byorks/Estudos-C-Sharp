using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{   // Ctrl + K + D identa o código
    public class Servico : Item
    {
        public int DuracaoEmHoras { get; set; }
        public override void Atualizar()
        {
            Console.WriteLine("Insira o novo nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Insira o novo preço: ");
            Preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a nova quantidade: ");
            DuracaoEmHoras = int.Parse(Console.ReadLine());
        }

        public static Servico CriarServico()
        {   
            // Instanciando um objeto servico de Servico
            Servico servico = new Servico();

            Console.WriteLine("Insira o nome: ");
            servico.Nome = Console.ReadLine();

            Console.WriteLine("Insira o preço: ");
            servico.Preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a duração em horas");
            servico.DuracaoEmHoras = Convert.ToInt32(Console.ReadLine());

            return servico;
        }
        public override void MostrarDetalhes()
        {
            Console.WriteLine($"ID: {Id}, Serviço: {Nome}, Preço: {Preco:C}, Duração: {DuracaoEmHoras} horas");
        }
    }
}
