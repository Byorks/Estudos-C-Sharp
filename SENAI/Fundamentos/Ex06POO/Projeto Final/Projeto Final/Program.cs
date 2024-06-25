using Projeto_Final.Services;
using Projeto_Final.Models;
using Projeto_Final.Utils;

// Instanciado as listas: Cliente, Funcionario, Produto, Transacoes
ClienteService clienteService = new ClienteService();
FuncionarioService funcionarioService = new FuncionarioService();
ProdutoService produtoService = new ProdutoService();
TransacaoService transacaoService = new TransacaoService(); 
CarrinhoService carrinhoService = new CarrinhoService();

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
    Console.WriteLine("9 - Criar produto");
    Console.WriteLine("10 - Deletar produto");
    Console.WriteLine("11 - Atualizar produto");
    Console.WriteLine("12 - Listar produtos");
    Console.WriteLine("13 - Iniciar transação");
    Console.WriteLine("15 - Limpar console");
    Console.WriteLine("16 - Sair do Programa");


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
        case 9: // Criar Produto - Ficar atenta com essa declaração de variável
            Produto produto = Produto.CriarProduto();
            produtoService.AdicionarProduto(produto);
            break;
        case 10: // Deletar Produto
            Console.WriteLine("Digite o ID do produto que gostaria de deletar");
            id = Convert.ToInt32(Console.ReadLine());
            produtoService.RemoverProduto(produtoService.BuscarPorId(id)) ;
            break;
        case 11: // Atualizar Produto
            Console.WriteLine("Digite o ID do produto que gostaria de atualizar");
            id = Convert.ToInt32(Console.ReadLine());
            // Tentar ler da direita para a esquerda as vezes ajuda
            produtoService.BuscarPorId(id).Atualizar();
            break;
        case 12: // Listar Produtos    
            DisplayHelper.MostrarProdutos(produtoService);
            break;
        case 13:
            Console.Clear();
            Console.WriteLine("InicializaNdo Compras");
            Console.WriteLine("Quem é o funcionário que inicializara a venda?");
            Console.WriteLine("Lista funcionários");
            // Mostra lista Funcionários
            DisplayHelper.MostrarFuncionarios(funcionarioService);
            Console.WriteLine("Selecione o Id do funcionário selecionado");
            int vendedorId = Convert.ToInt16(Console.ReadLine());
            Funcionario funcVendedor = funcionarioService.BuscarPorId(vendedorId);

            Console.ReadLine();
            
            Console.WriteLine($"Venda iniciada...\nOlá {funcVendedor.Nome}!");
            Console.WriteLine("Selecione o Cliente: ");

            // Se não tiver cliente, terei que usar um ID genérico?
            if (clienteService == null)
            {
                Console.WriteLine("Lista de Clientes vazia, gostaria de iniciar um cadastro?");
                Console.WriteLine("Digite (s)Sim ou (n)Não");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    clienteService.AdicionarCliente(Cliente.CriarCliente());
                }
                else
                {
                    Console.WriteLine("Cliente Genérico inicializado");                   
                }
 
            }
            DisplayHelper.MostrarClientes(clienteService);
            Console.WriteLine("Digite o Id do cliente selecionado.");
            int IdComprador = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Bem vindo a nossa loja (^o^)!");
            Transacao.IniciaCarrinho(vendedorId, IdComprador, produtoService, carrinhoService);
            break;
        case 15:
            Console.WriteLine("Pressione qualquer tecla para limpar...");
            Console.ReadKey();
            Console.ReadKey();
            Console.Clear();
            break;
        case 16:
            menu = false;
            break;
        default:
            Console.WriteLine("Opção inválida! Escolha novamente :D ");
            break;
    }
}