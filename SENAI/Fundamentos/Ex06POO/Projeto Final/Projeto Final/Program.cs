using Projeto_Final.Services;
using Projeto_Final.Models;
using Projeto_Final.Utils;

// Instanciado as listas: Cliente, Funcionario, Produto, Transacoes
ClienteService clienteService = new ClienteService();
FuncionarioService funcionarioService = new FuncionarioService();
ProdutoService produtoService = new ProdutoService();
TransacaoService transacaoService = new TransacaoService(); 
CarrinhoService carrinhoService = new CarrinhoService();
VendasService vendasService = new VendasService();

#region Cliente Funcionario e Produtos Predefinidos
//Cliente cliente1 = new Cliente("Joao","Rua Senaizera", "1196568881", 25,06,1999,"528.888.888-55");
Funcionario funcionario1 = new Funcionario("Pedro", "Caixa", "18", "8h");
Produto produto1 = new Produto("Pão", "Panificadora", 10, 2, 07, 2024, 1.0);
Produto produto2 = new Produto("Croissant", "Panificadora", 8, 3, 07, 2024, 3.0);

//clienteService.AdicionarCliente(cliente1);
funcionarioService.AdicionarFuncionario(funcionario1);
produtoService.AdicionarProduto(produto1);
produtoService.AdicionarProduto(produto2);

#endregion

Console.WriteLine("Mercadinho da Byork ^-^");


bool menu = true;
while (menu)
{
    Console.WriteLine("\nSelecione a opção desejada\n");
    Console.WriteLine("1 - Criar cliente");
    Console.WriteLine("2 - Deletar cliente");
    Console.WriteLine("3 - Atualizar cliente");
    Console.WriteLine("4 - Listar clientes\n");
    Console.WriteLine("5 - Criar funcionario");
    Console.WriteLine("6 - Deletar funcionario");
    Console.WriteLine("7 - Atualizar funcionario");
    Console.WriteLine("8 - Listar funcionarios\n");    
    Console.WriteLine("9 - Criar produto");
    Console.WriteLine("10 - Deletar produto");
    Console.WriteLine("11 - Atualizar produto");
    Console.WriteLine("12 - Listar produtos\n");
    Console.WriteLine("13 - Iniciar transação");
    Console.WriteLine("14 - Deletar transação");
    Console.WriteLine("15 - Atualizar transação");
    Console.WriteLine("16 - Listar transações\n");
    Console.WriteLine("17 - Limpar console");
    Console.WriteLine("18 - Sair do Programa\n");

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

    Console.Clear();
  
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
            Console.WriteLine("Clientes Cadastrados");
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
            Console.WriteLine("Funcionários Cadastrados");
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
            Console.Write("Digite o ID do produto que gostaria de atualizar: ");
            id = Convert.ToInt32(Console.ReadLine());
            // Tentar ler da direita para a esquerda as vezes ajuda
            produtoService.BuscarPorId(id).Atualizar();
            break;
        case 12: // Listar Produtos
            Console.WriteLine("Produtos Cadastrados");
            DisplayHelper.MostrarProdutos(produtoService);
            break;
        case 13:
            Console.Clear();
            Console.WriteLine("Inicializando Compras");
            Console.WriteLine("Quem é o funcionário que realizará a venda?\n");
            Console.WriteLine("Lista funcionários\n");
            // Mostra lista Funcionários
            DisplayHelper.MostrarFuncionarios(funcionarioService);
            Console.Write("\nSelecione o Id do funcionário selecionado: ");
            int vendedorId = Convert.ToInt16(Console.ReadLine());
            Funcionario funcVendedor = funcionarioService.BuscarPorId(vendedorId);

            Console.Clear();
            
            Console.WriteLine($"Venda inciada...\nOlá {funcVendedor.Nome}!");
            Console.WriteLine("\nSelecione o Cliente: ");

            // Se não tiver cliente, terei que usar um ID genérico?
            if (clienteService.ListarClientes().Exists(x => x.Id == 0) == false)
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
                    Cliente clienteGen = new Cliente ("Cliente", "Endereço não definido", "11 0000 0000", 0, 0, 0, "Não definido");
                    clienteService.AdicionarCliente(clienteGen);
                }

            }

            DisplayHelper.MostrarClientes(clienteService);
            Console.Write("\nDigite o Id do cliente selecionado: ");
            int IdComprador = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Bem vindo(a) a nossa loja (^o^)!");

            //
            Console.WriteLine("\n--- Venda Iniciada ---\n");

            Console.WriteLine($"Id do funcionario: {vendedorId}");
            Console.WriteLine($"Id do cliente selecionado: {IdComprador}");

            int cont = 0;
            double calcQtd = 0;
            double valorTotal = 0;
            bool selecaoProdutos = true;

            while (selecaoProdutos)
            {
                Console.WriteLine("\nLista de Produtos disponiveis:");
                DisplayHelper.MostrarProdutos(produtoService);
                Console.WriteLine("\nSelecione os produtos do seu interesse.");

                // Selecina o id do produto selecionado e a quantia
                Console.WriteLine("Digite o Id do produto desejado para adicionar ao carrinho");
                int idProdSelecionado = int.Parse(Console.ReadLine());
                // Aqui está copiando o produto da lita produtos
                Produto prodSelecionado = produtoService.BuscarPorId(idProdSelecionado);

                Console.WriteLine($"Quantidade Disponível em estoque: {prodSelecionado.QuantidadeEstoque}");
                Console.Write("Digite a quantia desejada: ");
                int quantidade = int.Parse(Console.ReadLine());

                prodSelecionado.QuantidadeCarrinho = quantidade;
                
                // Método que atualiza a quantidade do produto que foi comprado
                Produto.AtualizarQuantidade(produtoService.BuscarPorId(idProdSelecionado), quantidade);

                calcQtd = quantidade * prodSelecionado.Preco;

                valorTotal += calcQtd;

                cont++;
                // Produto selecionado tem que ir para a lista _produtosCarrinho
                carrinhoService.AdicionarCarrinho(prodSelecionado);

                Console.Clear();

                Console.WriteLine("\n--- Lista de Produtos no Carrinho ---\n");
                DisplayHelper.MostrarCarrinho(carrinhoService);

                Console.WriteLine($"Valor total {valorTotal}:");

                Console.WriteLine("\nGostaria de encerrar a operacao? (s)Sim (n)Não");
                if (Console.ReadLine() == "s")
                {
                    selecaoProdutos = false;
                    Console.WriteLine("Venda realizada com sucesso!\n");

                }
            }

            // Método para criar transacao e já passar para a lista
            transacaoService.AdicionarTransacao(Transacao.CriarTransacao(vendedorId, IdComprador, valorTotal, cont));

            // Passar o conteúdo de carrinho para vendas
            List<Produto> produtosCarrinho = carrinhoService.ListarCarrinho();
            var listaProduto = produtosCarrinho.Select(x => x).ToList();
            Console.WriteLine(produtosCarrinho);
            //// Vou usar um método para isso
            //Produto[] ProdVendidos = produtosCarrinho.ToArray();

            vendasService.AdicionarVendas(listaProduto);
            Console.WriteLine(vendasService.ListarVendas());
            //vendasService.AdicionarVendas(produtosCarrinho);

            // Limpa o carrinho
            carrinhoService.ListarCarrinho().Clear();

            Console.Clear();
            break;
        case 14:
            Console.WriteLine("--- Cancelamento de Transações ---");

            Console.WriteLine("Histórico de Transações\n");
            DisplayHelper.MostrarTransacoes(transacaoService, vendasService);

            Console.Write("Digite o ID da transação que deseja cancelar: ");
            int idSelect = int.Parse(Console.ReadLine());
            transacaoService.RemoverTransacao(transacaoService.BuscarTransacaoPorId(idSelect));
            // Aguardando refatoração de código
            //vendasService.RemoverVendas(vendasService.ProdutosCompradosID(idSelect));
            Console.WriteLine("Transação cancelada com sucesso! ;D");
            // Dá para colocar sistema de confirmação de delete
            break;
        case 15:
            AtualizarTransacao();
            break;
        case 16: // Listar transacoes
            Console.WriteLine("Histórico de Transações\n");
            DisplayHelper.MostrarTransacoes(transacaoService, vendasService);
            //DisplayHelper.MostrarVendas(vendasService,0);            
            break;
        case 17:
            Console.WriteLine("Pressione qualquer tecla para limpar...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 18:
            menu = false;
            break;
        default:
            Console.WriteLine("Opção inválida! Escolha novamente :D ");
            break;
    }
}

void AtualizarTransacao()
{
    //Definindo algoritmo para iniciar a atualização da transação
    Console.WriteLine("--- Atualizar Transação ---");
    Console.WriteLine("Histórico de Transações\n");
    DisplayHelper.MostrarTransacoes(transacaoService);

    //Selecionar a transação pelo id
    Console.Write("Digite o ID da transação que deseja alterar");
    Transacao transacaoAtualizar = transacaoService.BuscarTransacaoPorId(Int32.Parse(Console.ReadLine()));

    Console.WriteLine("Digite a opção desejada");

    Console.WriteLine($"Menu Atualizar Transação de ID: {transacaoAtualizar.Id}\n");
    Console.WriteLine("1 - Atualizar Cliente");
    Console.WriteLine("2 - Atualizar Funcionário");
    Console.WriteLine("3 - Troca ou devolução de produtos");

    int idTransacao = transacaoAtualizar.Id;

    int menuTr;
    menuTr = Int32.Parse(Console.ReadLine());
    switch (menuTr)
    {
        case 1:
            Console.WriteLine("Buscando Cliente...\n");
            clienteService.BuscarPorId(transacaoAtualizar.IdCliente).Atualizar(); 
            break;
        case 2:
            Console.WriteLine("Buscando Funcionário...\n");
            funcionarioService.BuscarPorId(transacaoAtualizar.IdFuncionario).Atualizar();
            break;
        case 3:
            Console.WriteLine("Troca ou Devolução de Produtos");
            // Descobrir como alterar elementos de dentro da lista
            List<Produto> listaProdutosAtualizar = vendasService.ProdutosCompradosID(transacaoAtualizar.Id);
            Console.Write("Informe a opção desejada (Troca ou Devolução): ");
            if (Console.ReadLine().ToLower() == "troca")
            {
                Console.WriteLine("Lista de Produtos da Transação");
                DisplayHelper.MostrarProdutos(listaProdutosAtualizar);

                Console.Write("\n Selecione o número do produto que deseja trocar: \n");
                int prodTrocaPosicao = Int32.Parse(Console.ReadLine());
                listaProdutosAtualizar.RemoveAt(prodTrocaPosicao);

                Console.WriteLine("Lista de produtos disponíveis");
                DisplayHelper.MostrarProdutos(produtoService);

                Console.Write("Digite o ID do produto que deseja: ");
                Produto prodTroca = produtoService.BuscarPorId(Int32.Parse(Console.ReadLine()));

                Console.WriteLine($"Quantidade disponível em estoque : {prodTroca.QuantidadeEstoque} ");
                Console.Write("\nDigite a quantidade desejada: ");
                int quantidadeTr = Int32.Parse(Console.ReadLine());
                prodTroca.QuantidadeCarrinho = quantidadeTr;
                Produto.AtualizarQuantidade(produtoService.BuscarPorId(prodTroca.Id), quantidadeTr);

                listaProdutosAtualizar.Insert(prodTrocaPosicao, prodTroca);
                //Criando uma nova lista a partir daquela
                var listaAtualizada = listaProdutosAtualizar.Select(x => x).ToList();

                // Tem que testar e ver se dá certo
                transacaoAtualizar.ValorTotal = prodTroca.Preco * quantidadeTr;

                vendasService.AdicionarVendasPosicao(listaAtualizada, transacaoAtualizar.Id);
                vendasService.RemoverVendas(vendasService.ProdutosCompradosID(transacaoAtualizar.Id+1));
                Console.WriteLine("Troca Realizada com sucesso!");

            }
            break;
        default:
            break;
    }
    //    Pega a transação e a lista vendas correspondente
    //    Selecionar o que quer fazer: 
    //		Opções:
    //Atualizar Cliente -caso tenha algum erro no registro
    //			Atualizar Funcionário - mesma coisa de cimas
    //			Troca ou devolução de produtos
    //				Consequentemente o valor total vai mudar!
}