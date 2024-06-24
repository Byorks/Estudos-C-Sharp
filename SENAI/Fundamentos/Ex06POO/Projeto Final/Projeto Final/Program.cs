using Projeto_Final.Services;
using Projeto_Final.Models;
using Projeto_Final.Utils;

// Instanciado a lista de clientes
ClienteService clienteService = new ClienteService();

Console.WriteLine("Mercadinho da Vanessa");


bool menu = true;
while (menu)
{
    Console.WriteLine("Selecione a opção desejada");
    Console.WriteLine("1 - Criar cliente");
    Console.WriteLine("2 - Listar clientes");
    Console.WriteLine("7 - Sair do Programa");

    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Cliente cliente = Cliente.CriarCliente();
            clienteService.AdicionarCliente(cliente);
            break;
        case 2:
            DisplayHelper.MostrarClientes(clienteService);
            break;
        case 7:
            menu = false;
            break;
        default:
            Console.WriteLine("Opção inválida! Escolha novamente :D ");
            break;
    }
}