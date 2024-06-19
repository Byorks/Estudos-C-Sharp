using Inventario.Models;
using Inventario.Services;
using Inventario.Utils;

InventarioServices inventarioService = new InventarioServices();

bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine(" --------------- Sistema de Inventário do Holandinha --------------- ");
    Console.WriteLine(" -------------------------------- ^_^ --------------------------------");
    Console.WriteLine("1. Adicionar Produto ................................................:");
    Console.WriteLine("2. Adicionar Serviço ................................................:");
    Console.WriteLine("3. Listar Itens .....................................................:");
    Console.WriteLine("4. Atualizar Item ...................................................:");
    Console.WriteLine("5. Remover Item .....................................................:");
    Console.WriteLine("6. Sair .............................................................:");
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine("");

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Produto produto = Produto.CriarProduto();
            inventarioService.AdicionarItem(produto);
            break;
        case 2:
            Servico servico = Servico.CriarServico();
            inventarioService.AdicionarItem(servico);
            break;
        case 3:
            DisplayHelper.MostrarInventario(inventarioService);
            break;
        case 4:
            AtualizarItem(inventarioService);
            break;
        case 5:
            RemoverItem(inventarioService);
            break;
        case 6:
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente");
            break;
    }

    if (continuar)
    {

    }
}