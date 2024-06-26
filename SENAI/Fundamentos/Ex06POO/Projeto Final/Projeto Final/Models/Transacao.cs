using Projeto_Final.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Final.Utils;

namespace Projeto_Final.Models
{
    public class Transacao
    {
        public int Id { get;  set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }
        public string DataTransacao { get; set; }
        public string HoraTransacao { get; set; }
        public static DateTime Now { get; }
        // Lista dos produtos comprados
        public double ValorTotal { get; set; }

        public static Transacao IniciaCarrinho(int idFun, int idCliente, ProdutoService produtoService, CarrinhoService carrinhoService)
        {
            Console.WriteLine("\n--- Venda Iniciada ---\n");

            Transacao transacao = new Transacao();
            // Selecionar o produto entre a lista de produtos

            // Escolha o funcionário que vai iniciar a transação, sem funcionário, sem transacão
            Console.WriteLine($"Id do funcionario: {idFun}");
            transacao.IdFuncionario = idFun;
            // Selecione o Cliente - Acho que terei de usar o this
                Console.WriteLine($"Id do cliente selecionado: {idCliente}");
                transacao.IdCliente = idCliente;

            // Se não tiver cliente, será um cliente genérico

            // Mostrar lista de produtos disponíveis
            double calcQtd = 0;
            double ValorTotal = 0;
            bool selecaoProdutos = true;
            while(selecaoProdutos)
            {   
                Console.WriteLine("\nLista de Produtos disponiveis:");
                DisplayHelper.MostrarProdutos(produtoService);
                Console.WriteLine("\nSelecione os produtos do seu interesse.");
                // Selecina o id do produto selecionado e a quantia
                Console.WriteLine("Digite o Id do produto desejado para adicionar ao carrinho");
                int idProd = int .Parse(Console.ReadLine());

                // Aqui está copiando o produto da lita produtos
                Produto prodSelecionado = produtoService.BuscarPorId(idProd);
                Console.WriteLine($"Quantidade Disponível em estoque: {prodSelecionado.QuantidadeEstoque}");
                Console.WriteLine("Digite a quantia desejada: ");
                int quantidade = int.Parse(Console.ReadLine());

                Produto.AtualizarQuantidade(produtoService.BuscarPorId(idProd), quantidade);
                
                calcQtd = quantidade * prodSelecionado.Preco;

                ValorTotal += calcQtd;
                
                // Produto selecionado tem que ir para a lista _produtosCarrinho
                carrinhoService.AdicionarCarrinho(prodSelecionado);
                // Busca o Id na lista ProdutoService
                // Se tiver, adiciona/ copia o produto inteiro a lista CarrinhoService, porém, devo subtrair a quantidade selecionada

                // Mostrar a lista de produtos selecionados
                Console.WriteLine("\n--- Lista de Produtos no Carrinho ---\n");
                DisplayHelper.MostrarCarrinho(carrinhoService);

                Console.WriteLine($"Valor total {ValorTotal}:");

                Console.WriteLine("\nGostaria de encerrar a operacao? (s)Sim");
                
                if (Console.ReadLine() == "s")
                {
                    selecaoProdutos = false;
                }
                // Cuidado com esse clear
                Console.Clear();
                // falta contabilizar a quantidade
            }

            // Selecionar os produtos de interesse, 1 por 1?
            // Escolher a quantidade, e verificar se tem a quantidade disponível no estoque

            // Vai querer mais produtos - verifica a lista

            // Finalizar trasacao -  Venda
            transacao.ValorTotal = ValorTotal;

            // Verificar horário da trasação
            transacao.HoraTransacao = DateTime.Now.ToString("h:mm:ss tt");

            // Verificar Data da transação
            transacao.DataTransacao = DateTime.Now.ToString("d/MM/yyyy");

            Console.WriteLine("Venda realizada com sucesso!");
            return transacao;
        }
        // CRUD para transações de Vendas

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Id: {Id}, Id Funcionario: {IdFuncionario}, Id Cliente: {IdCliente}, Data da transação: {DataTransacao}, Horário da transação: {HoraTransacao}, Valor Total R$ {ValorTotal:C}");
        }

        // Não implementado
        public void MostrarDetalhesCarriho()
        {
            Console.WriteLine($"Id: {Id}, Id Funcionario: {IdFuncionario}, Id Cliente: {IdCliente}, Data da transação: {DataTransacao}, Horário da transação: {HoraTransacao}, Valor Total R$ {ValorTotal:C}");

        }
    }
}
