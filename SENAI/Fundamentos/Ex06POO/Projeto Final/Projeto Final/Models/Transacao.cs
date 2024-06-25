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
        public int Id { get; protected set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }
        public int DataTransacao { get; set; }
        public int HoraTransacao { get; set; }
        // Lista dos produtos comprados
        public double ValorTotal { get; set; }

        public static Transacao IniciaCarrinho(int idFun, int idCliente, ProdutoService produtoService, CarrinhoService carrinhoService)
        {
            Console.WriteLine("Venda Iniciada");

            Transacao transacao = new Transacao();
            // Selecionar o produto entre a lista de produtos

            // Escolha o funcionário que vai iniciar a transação, sem funcionário, sem transacão
            Console.WriteLine($"Id do funcionario: {idFun}");
            transacao.IdFuncionario = idFun;
            // Selecione o Cliente - Acho que terei de usar o this
                Console.WriteLine($"Id do cliente selecionado: {idFun}");
                transacao.IdFuncionario = idFun;

            // Se não tiver cliente, será um cliente genérico

            // Mostrar lista de produtos disponíveis
            double calcQtd = 0;
            double ValorTotal = 0;
            bool selecaoProdutos = false;
            while(selecaoProdutos)
            {
                DisplayHelper.MostrarProdutos(produtoService);
                Console.WriteLine("\nSelecione os produtos do seu interesse.");
                // Selecina o id do produto selecionado e a quantia
                Console.WriteLine("Digite o Id do produto do seu interesse");
                int idProd = int .Parse(Console.ReadLine());

                Produto prodSelecionado = produtoService.BuscarPorId(idProd);
                Console.WriteLine($"Quantidade Disponível em estoque: {prodSelecionado.QuantidadeEstoque}");
                Console.WriteLine("Digite a quantia desejada: ");
                int quantidade = int.Parse(Console.ReadLine());

                calcQtd = quantidade * prodSelecionado.Preco;

                ValorTotal += calcQtd;
                
                // Busca o Id na lista ProdutoService
                // Se tiver, adiciona/ copia o produto inteiro a lista CarrinhoService, porém, devo subtrair a quantidade selecionada

                Console.WriteLine("Gostaria de encerrar a operacao? (s)Sim");
                
                if (Console.ReadLine() == "s")
                {
                    selecaoProdutos = true;
                }
                // Cuidado com esse clear
                Console.Clear();
                Console.ReadKey();           
            }

            // Selecionar os produtos de interesse, 1 por 1?
            // Escolher a quantidade, e verificar se tem a quantidade disponível no estoque

            // Vai querer mais produtos - verifica a lista

            // Finalizar trasacao -  Venda
            transacao.ValorTotal = ValorTotal;

            // Verificar horário da trasação

            // Verificar Data da transação
            return transacao;
        }
        // CRUD para transações de Vendas

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Id: {Id}, Id Funcioanrio: {IdFuncionario}, Id cliente: {IdCliente}, Data da  transação: {DataTransacao}, Horário da transação: {HoraTransacao}, Valor Total: {ValorTotal}");
        }
    }
}
