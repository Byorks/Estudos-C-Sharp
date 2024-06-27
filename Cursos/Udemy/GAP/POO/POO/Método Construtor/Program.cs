using Método_Construtor;
// Nenhum dos valores foi definidor, portanto os retornos serão nulls e zeros
// Não foram inicializados

// Método construtor entra aqui
Pessoa p1 = new Pessoa();

Console.WriteLine(p1.Nome);
Console.WriteLine(p1.Sobrenome);
Console.WriteLine(p1.AnoNascimento);
Console.WriteLine(p1.Idade);

Console.WriteLine();

Pessoa p2 = new Pessoa("Vanessa", "Ferreira", 1999);
Console.WriteLine(p2.Nome);
Console.WriteLine(p2.Sobrenome);
Console.WriteLine(p2.AnoNascimento);
Console.WriteLine(p2.Idade);

Console.WriteLine();

Pessoa p3 = new Pessoa("Diogo", "Botton");
Console.WriteLine(p3.Nome);
Console.WriteLine(p3.Sobrenome);
Console.WriteLine(p3.AnoNascimento);
Console.WriteLine(p3.Idade);

Console.ReadKey();

