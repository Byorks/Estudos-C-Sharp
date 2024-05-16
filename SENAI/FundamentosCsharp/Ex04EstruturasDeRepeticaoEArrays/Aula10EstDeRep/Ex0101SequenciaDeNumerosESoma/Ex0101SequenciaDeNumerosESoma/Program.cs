// Leia um conjunto não determinado de pares
// de valores M e N (parar quando algum dos
// valores for menor ou igual a zero). Para cada
// par lido, mostre a sequência do menor até o
// maior e a soma dos inteiros consecutivos
// entre eles (incluindo o N e M).

int numA = 1, numB = 1, soma = 0;

while (numA > 0 && numB > 0) {

    string[] entrada = Console.ReadLine().Split(' ');

    numA = int.Parse(entrada[0]);

    numB = int.Parse(entrada[1]);

    Console.WriteLine($"primeira entrada: {numA}, segunda entrada: {numB}");

    if( numA == 0 || numB == 0)
    {
        break;
    }

    if (numA > numB)
    {
        int numC = numB;
        numB = numA;
        numA = numC;
    }
    
    for (int cont = numA; cont <= numB; cont++ )
    {
        Console.Write($" {cont}");
        
        soma += cont;
        
    }

    Console.WriteLine($" Soma= {soma}");
    soma = 0;
}

Console.WriteLine("Fim do código");
