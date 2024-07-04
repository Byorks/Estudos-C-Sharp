using ApiCSharp.Models;
using ApiCSharp.Repository;

var builder = WebApplication.CreateBuilder(args);

// Não tem magia, não é necessário decorar, são necessários para o funcionamento do programa
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

// CTRL + . = Sugestões de Correção
var produtoRepository = new ProdutoRepository();

app.MapGet("/", () => "Hello World!");

// Definindo rota listar produtos, que retorna uma mensagem
app.MapGet("/listarProdutos", () => Results.Ok(produtoRepository.ListarProdutos()));

// Cadastrar (Estou entregando um 'produto') 
app.MapPost("/cadastrarProduto", (Produto produto) => Results.Ok(produtoRepository.CadastrarProduto(produto)));

app.UseSwaggerUI();

app.Run();
