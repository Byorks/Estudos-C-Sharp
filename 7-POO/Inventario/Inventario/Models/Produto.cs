using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{   
    // Clica na Classe - Ctrl + . e Implementar Classe abstrata
    public class Produto : Item
    {   
        // Produto tem quantidade, portanto esse atributo foi atualizado
        public int Quantidade { get; set; }

        // CRUD - Update
        public override void Atualizar()
        {
            Console.WriteLine("Insira o novo nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Insira o novo preço: ");
            Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nova quantidade");
            Quantidade = int.Parse(Console.ReadLine());

            // Quando implementa o método automaticamente, ele usa o método NIE para não precisar implementar o método
            // throw new NotImplementedException();
        }
        // CRUD - Create, o método vai devolver um objeto do tipo Produto, então obrigatóriamente temos que encher ele de coisas
        public static Produto CriarProduto()
        {
            Produto produto = new Produto();

            Console.WriteLine("Insira o nome do produto:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Insira o preço do produto:");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            return produto;
        }
        public override void MostrarDetalhes()
        {   
            // Interpolação de String
            // Esse "C" serve para automaticamente colocar o R$ de acordo com a localização, não precisa nem de colocar .ToString
            Console.WriteLine($"ID: {Id}, Produto: {Nome}, Preço: {Preco:C}");
        }
    }
}
