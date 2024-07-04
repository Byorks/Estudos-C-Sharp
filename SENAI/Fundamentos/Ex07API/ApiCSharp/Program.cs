using ApiCSharp.Models;
using ApiCSharp.Repository;

var builder = WebApplication.CreateBuilder(args);

// N�o tem magia, n�o � necess�rio decorar, s�o necess�rios para o funcionamento do programa
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

// CTRL + . = Sugest�es de Corre��o
var produtoRepository = new ProdutoRepository();

app.MapGet("/", () => "Hello World!");

// Definindo rota listar produtos, que retorna uma mensagem
app.MapGet("/listarProdutos", () => Results.Ok(produtoRepository.ListarProdutos()));

// Cadastrar (Estou entregando um 'produto') 
app.MapPost("/cadastrarProduto", (Produto produto) => Results.Ok(produtoRepository.CadastrarProduto(produto)));

app.UseSwaggerUI();

app.Run();
