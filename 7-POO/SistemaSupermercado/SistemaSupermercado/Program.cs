using SistemaSupermercado.Models;
using SistemaSupermercado.Service;

ProdutoService produtoService = new ProdutoService();

int opcao = 0;

Console.WriteLine("Sistema de Supermercados");

Console.WriteLine("Bem vindo ao Sistema");

Console.WriteLine("Selecione a opção que deseja");


do
{
    Console.WriteLine("Selecione o método que deseja");

    Console.WriteLine("1 - Cliente");
    Console.WriteLine("2 - Funcionário");
    Console.WriteLine("3 - Produto");
    Console.WriteLine("4 - Transação");

    opcao = Int32.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Método ainda não implementado");
            break;
        case 2:
            Console.WriteLine("Método ainda não implementado");
            break; 
        case 3:
            EscolherMetodo();
            break; 
        case 4:
            Console.WriteLine("Método ainda não implementado");
            break;
        default:
            Console.WriteLine("Número invalido!");
            break;
    }

} while (opcao != 0);

void EscolherMetodo()
{
    int opcaoMetodo = 0;

    Console.WriteLine("Selecione o método que deseja");

    Console.WriteLine("1 - Listar");
    Console.WriteLine("2 - Cadastrar");
    Console.WriteLine("3 - Editar");
    Console.WriteLine("4 - Deletar");

    opcaoMetodo = Int32.Parse(Console.ReadLine());

    switch (opcaoMetodo)
    {
        case 1:
            produtoService.Listar();
            break;
        case 2:
            produtoService.Cadastrar(CadastrarProduto());
            break;
        case 3:

            break;
        case 4:
            Console.WriteLine("Método ainda não implementado");
            break;
        default:
            Console.WriteLine("Número invalido!");
            break;
    }

}

Produto CadastrarProduto ()
{   
    Produto produto = new Produto();

    Console.WriteLine("Digite o nome: ");
    produto.Nome = Console.ReadLine();

    Console.WriteLine("Digite a Categoria: ");
    produto.Categoria = Console.ReadLine();

    Console.WriteLine("Digite o Preço: ");
    produto.Preco = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a Quantidade: ");
    produto.QuantidadeEstoque = Int32.Parse(Console.ReadLine()); 
    
    Console.WriteLine("Digite a Data de Validade: (DD//MM/YYYY) ");
    produto.DataValidade = DateTime.Parse(Console.ReadLine());

    return produto;
}










