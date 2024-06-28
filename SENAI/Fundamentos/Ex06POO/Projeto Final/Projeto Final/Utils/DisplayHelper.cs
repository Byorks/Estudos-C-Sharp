using Projeto_Final.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Final.Models;

namespace Projeto_Final.Utils
{
    internal static class DisplayHelper
    {
        // Buscar forma de unificar o método, possível sol. overload? Generics?
        public static void MostrarClientes(ClienteService clienteService)
        {
            // A _listaclientes está sendo recebida pela listaClientes
            List<Cliente> listaClientes = clienteService.ListarClientes();
            // Para cada "cliente" na lista, excutaremos um método, que fará escrever os detalhes na tela
            foreach (Cliente cliente in listaClientes)
            {
                cliente.MostrarDetalhesCliente();
            }
        }    

        public static void MostrarFuncionarios(FuncionarioService funcionarioService)
        {
            List<Funcionario> listaFuncionarios = funcionarioService.ListarFuncionarios();

            foreach ( Funcionario funcionario in listaFuncionarios)
            {
                funcionario.MostrarDetalhes();
            }
        }

        public static void MostrarProdutos (ProdutoService produtoService)
        {
            List<Produto> listaProdutos = produtoService.ListarProdutos();
            foreach ( Produto produto in listaProdutos)
            {
                produto.MostrarDetalhes();
            }
        }

        public static void MostrarTransacoes (TransacaoService transacaoService )
        {
            List<Transacao> listaTransacoes = transacaoService.ListarTransacoes();
            foreach (Transacao transacao in listaTransacoes)
            {
                transacao.MostrarDetalhes();
            }
        }

        public static void MostrarCarrinho (CarrinhoService carrinhoService ) 
        { 
            List<Produto> listaCarrinho = carrinhoService.ListarCarrinho();
            foreach (Produto produto in listaCarrinho)
            {
                produto.MostrarCarrinho();
            }
        }

        public static void MostrarVendas (VendasService vendasService, int id)
        {
            // Quero que mostre os produtos do index == ID
            List<Produto> listaVendas = vendasService.ProdutosCompradosID(id);
            foreach (Produto produto in listaVendas)
            {   
                // Ver se está mostrando mesmo
                produto.MostrarDetalhes();
            }
            
        }

        public static void MostrarTransacoes(TransacaoService transacaoService, VendasService vendasService)
        {
            List<Transacao> transacoes = transacaoService.ListarTransacoes();
            foreach(Transacao transacao in transacoes)
            {
                // É aqui que entra a lógica

                transacao.MostrarDetalhes();
                List<List<Produto>> produtos = vendasService.ListarVendas();
                for( int i = 0; i < produtos.Count; i++)
                {
                    Console.WriteLine(produtos[i]);
                }
            }
        }
    }
}
