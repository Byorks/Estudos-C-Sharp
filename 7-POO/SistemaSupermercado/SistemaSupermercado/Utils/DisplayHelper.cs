using SistemaSupermercado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercado.Utils
{
    public static class DisplayHelper
    {
        public static void ExibirProduto(Produto prod)
        {
            // \t Da um tab na linha
            // Concatenar
            //Console.WriteLine("Nome: " + prod.Nome);
            // Interpolar
            Console.WriteLine($"Id: {prod.Id}");
            Console.WriteLine($"Nome: {prod.Nome}");
            Console.WriteLine($"Categoria: {prod.Categoria}");
            Console.WriteLine($"Preço: {prod.Preco}");
            Console.WriteLine($"Quantidade em Estoque: {prod.QuantidadeEstoque}");
            Console.WriteLine($"Data de Validade: {prod.DataValidade}\n");
        }

         public static void ExibirCliente(Cliente cliente)
        {
            Console.WriteLine($"Id: {cliente.Id}");
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Endereco: {cliente.Endereco}");
            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}\n");
            Console.WriteLine($"Número de Telefone: {cliente.NumeroTelefone}\n");
        }

         public static void ExibirFuncionario(Funcionario funcionario)
        {
            // \t Da um tab na linha
            // Concatenar
            //Console.WriteLine("Nome: " + prod.Nome);
            // Interpolar
            Console.WriteLine($"Id: {funcionario.Id}");
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Cargo: {funcionario.Cargo}");
            Console.WriteLine($"Número Registro: {funcionario.NumeroRegistro}");
            Console.WriteLine($"Horário de trabalho: {funcionario.HorarioTrabalho}");
        }

         public static void ExibirTransacao(Transacao transacao)
        {

            Console.WriteLine($"Id: {transacao.Id}");
            Console.WriteLine($"Id do Funcionário: {transacao.IdFuncionario}");
            Console.WriteLine($"Id do Cliente: {transacao.IdCliente}");
            Console.WriteLine($"Data da Transação: {transacao.DataTransacao}\n");
            Console.WriteLine($"Valor Total: {transacao.ValorTotal}\n");

            foreach (var item in transacao.Produtos)
            {
                ExibirProduto(item);
            }
         }



    }
}
