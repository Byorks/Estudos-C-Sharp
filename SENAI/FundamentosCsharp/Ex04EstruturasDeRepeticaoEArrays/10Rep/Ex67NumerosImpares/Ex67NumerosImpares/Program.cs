//Leia um valor inteiro X (1 <= X <= 1000). Em seguida
//mostre os ímpares de 1 até X, um valor por linha,
//inclusive o X, se for o caso.

int X;
Console.WriteLine("Esse programa mostra os números impares até o valor de X");
Console.WriteLine("Insira o valor de X, sendo ele maior ou igual a 1 e menor ou igual a 1000");
X = int .Parse(Console.ReadLine());

for (int i = 1; i < X; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine("valor impar " + i);
    }
}