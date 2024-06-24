using Projeto_Final.Services;
using Projeto_Final.Models;
using Projeto_Final.Utils;

// Instanciado a lista de clientes
ClienteService clienteService = new ClienteService();
FuncionarioService funcionarioService = new FuncionarioService();

Console.WriteLine("Mercadinho da Vanessa");


bool menu = true;
while (menu)
{
    Console.WriteLine("Selecione a opção desejada");
    Console.WriteLine("1 - Criar cliente");
    Console.WriteLine("2 - Deletar cliente");
    Console.WriteLine("3 - Atualizar cliente");
    Console.WriteLine("4 - Listar clientes");
    Console.WriteLine("5 - Criar funcionario");
    Console.WriteLine("6 - Deletar funcionario");
    Console.WriteLine("7 - Atualizar funcionario");
    Console.WriteLine("8 - Listar funcionarios");
    Console.WriteLine("10 - Sair do Programa");

    string opcao;
    int opcaoNum, id;
    opcao = Console.ReadLine();
    bool opcaoVerificacao = Int32.TryParse(opcao, out opcaoNum);

    while (!opcaoVerificacao)
    {
        Console.WriteLine("Por favor, digite um número");
        Console.WriteLine("Digite a opção desejada");
        opcao = Console.ReadLine();
        opcaoVerificacao = Int32.TryParse(opcao, out opcaoNum);
    }

    switch (opcaoNum)
    {
        case 1:
            Cliente cliente = Cliente.CriarCliente();
            clienteService.AdicionarCliente(cliente);
            break;
        case 2:
            Console.WriteLine("Digite o Id do cliente que gostaria de remover: ");
            id = Convert.ToInt32(Console.ReadLine());
            clienteService.RemoverCliente(clienteService.BuscarPorId(id));
            // Verificar se o retorno é null, precisa?
            break;
        case 3:
            // Atualizar Cliente
            Console.WriteLine("Digite o Id do cliente que gostaria de atualizar");
            id = Convert.ToInt32(Console.ReadLine());

            if (!(clienteService.BuscarPorId(id) == null))
            {
                clienteService.BuscarPorId(id).Atualizar();
            }
            // Erro por retornar null encontrado
            break;
        case 4:
            DisplayHelper.MostrarClientes(clienteService);
            break;
        case 5:
            Funcionario funcionario = Funcionario.CriarFuncionario();
            funcionarioService.AdicionarFuncionario(funcionario);
            break;
        case 6:
            //Deletar fun
            Console.WriteLine("Digite o ID do funcionario que gostaria de deletar");
            id = Convert.ToInt32(Console.ReadLine());
            funcionarioService.RemoverFuncionario(funcionarioService.BuscarPorId(id));
            break;
        case 7:
            // Atualizar fun
            Console.WriteLine("Digite o ID do funcionario que gostaria de atualizar");
            id = Convert.ToInt32(Console.ReadLine());
            if(!(funcionarioService.BuscarPorId(id) == null))
            {
                funcionarioService.BuscarPorId(id).Atualizar();             
            }
            break;
        case 8:
            DisplayHelper.MostrarFuncionarios(funcionarioService);
            break;
        case 10:
            menu = false;
            break;
        default:
            Console.WriteLine("Opção inválida! Escolha novamente :D ");
            break;
    }
}