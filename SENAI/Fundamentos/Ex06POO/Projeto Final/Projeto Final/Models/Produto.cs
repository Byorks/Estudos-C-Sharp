﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int QuantidadeCarrinho { get; set; }
        public int DiaValidade{ get; set; }
        public int MesValidade{ get; set; }
        public int AnoValidade{ get; set; }
        public double Preco { get; set; }

        static public Produto CriarProduto()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine("Criando um novo produto");

            Console.WriteLine("Informe o nome do produto");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine("Informe a categoria do produto");
            novoProduto.Categoria = Console.ReadLine();

            Console.WriteLine("Informe a quantidade em estoque do produto");
            novoProduto.QuantidadeEstoque = Convert.ToInt32(Console.ReadLine());

            // Tem que ajustar para verificar se o usuário está entrando um ano corretamente
            string[] dataValidade = new string[3];
            Console.WriteLine("Informe a data de validade do produto (Ex: DD/MM/AAAA)");
            dataValidade = Console.ReadLine().Split('/') ;

            novoProduto.DiaValidade = int.Parse(dataValidade[0]);
            novoProduto.MesValidade = int.Parse(dataValidade[1]);
            novoProduto.AnoValidade = int.Parse(dataValidade[2]);

            Console.WriteLine("Informe o preço do produto: ");
            novoProduto.Preco = double.Parse(Console.ReadLine());   

            return novoProduto; 
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"ID: {Id}, Nome: {Nome}, Categoria {Categoria}, Quantidade em estoque: {QuantidadeEstoque}, DataValidade: {DiaValidade}/{MesValidade}/{AnoValidade}, Preço {Preco:C}");
        }
        public string MostrarCarrinho()
        {
            string carrito = $"ID: {Id}\nNome: {Nome}\nCategoria {Categoria}\nQuantidade no Carrinho: {QuantidadeCarrinho}\nDataValidade: {DiaValidade}/{MesValidade}/{AnoValidade}\nPreço {Preco:C}\n";
            Console.WriteLine(carrito);
            return carrito;
        }

        public void Atualizar()
        {
            Console.WriteLine("Atualizando um produto");

            Console.WriteLine("Informe o novo nome do produto");
            Nome = Console.ReadLine();

            Console.WriteLine("Informe a nova categoria do produto");
            Categoria = Console.ReadLine();

            Console.WriteLine("Informe a nova quantidade em estoque do produto");
            QuantidadeEstoque = Convert.ToInt32(Console.ReadLine());

            // Tem que ajustar para verificar se o usuário está entrando um ano corretamente
            string[] dataValidade = new string[3];
            Console.WriteLine("Informe a nova data de validade do produto (Ex: DD/MM/AAAA)");
            dataValidade = Console.ReadLine().Split('/');

            DiaValidade = int.Parse(dataValidade[0]);
            MesValidade = int.Parse(dataValidade[1]);
            AnoValidade = int.Parse(dataValidade[2]);

            Console.WriteLine("Informe o novo preço do produto: ");
            Preco = double.Parse(Console.ReadLine());
        }

        public static void AtualizarQuantidade(Produto prodSelecionado, int qtd)
        {
            prodSelecionado.QuantidadeEstoque -= qtd;
        }
    }
}
