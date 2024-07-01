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

        public static Transacao CriarTransacao (int idFun, int idCliente, double valorTotal)
        {

            Transacao transacao = new Transacao();
            
            transacao.IdFuncionario = idFun;
            
            transacao.IdCliente = idCliente;

            transacao.ValorTotal = valorTotal;

            // Verificar horário da trasação
            transacao.HoraTransacao = DateTime.Now.ToString("HH:mm:ss tt");

            // Verificar Data da transação
            transacao.DataTransacao = DateTime.Now.ToString("d/MM/yyyy");

            return transacao;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Id: {Id}, Id Funcionario: {IdFuncionario}, Id Cliente: {IdCliente}, Data da transação: {DataTransacao}, Horário da transação: {HoraTransacao}, Valor Total {ValorTotal:C}");
            Console.WriteLine("Produtos adquiridos");

        }

        public void MostrarDetalhesCarrinho()
        {
            string carrinho = $"Id: {Id}, Id Funcionario: {IdFuncionario}, Id Cliente: {IdCliente}, Data da transação: {DataTransacao}, Horário da transação: {HoraTransacao}, Valor Total R$ {ValorTotal:C}";
            Console.WriteLine(carrinho);

        }
    }
}
