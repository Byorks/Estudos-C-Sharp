// Leia um conjunto não determinado de pares
// de valores M e N (parar quando algum dos
// valores for menor ou igual a zero). Para cada
// par lido, mostre a sequência do menor até o
// maior e a soma dos inteiros consecutivos
// entre eles (incluindo o N e M).

int m, n;

    string[] entrada = Console.ReadLine().Split(' ');

    m = int.Parse(entrada[0]);

    n = int.Parse(entrada[1]);

while (m > 0 && n > 0)
{

    Console.WriteLine($"primeira entrada: {m}, segunda entrada: {n}");

    if (m == 0 || n == 0)
    {
        break;
    }

    if (m > n)
    {
        int numC = n;
        n = m;
        m = numC;
    }
    int soma = 0;
    for (int cont = m; cont <= n; cont++)
    {
        Console.Write($" {cont}");

        soma += cont;

    }

    Console.WriteLine($" Soma= {soma}");

    entrada = Console.ReadLine().Split(' ');

    m = int.Parse(entrada[0]);

    n = int.Parse(entrada[1]);

}

Console.WriteLine("Fim do código");

//falta testar
