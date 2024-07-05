
using SENAI.MinimalAPI.Context;
using SENAI.MinimalAPI.Model;
using SENAI.MinimalAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

var repo = new ProdutoRepository();

using var db = new ProdutoContext();

// app.MapControllers();

app.UseSwagger();

app.MapGet("/", () => db.DbPath);

app.MapGet("/listaProdutos", () =>
{
    return repo.ListarProdutos();
});

app.MapPost("/cadastrarProduto", (Produto prod) =>
{
    repo.CadastrarProduto(prod);
    return Results.Created("/cadastrarProduto", prod);
});

//db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
//db.SaveChanges();

app.UseSwaggerUI();

app.Run();
