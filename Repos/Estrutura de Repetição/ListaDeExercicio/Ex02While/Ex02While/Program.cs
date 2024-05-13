int numero = int.Parse(Console.ReadLine());
int soma = 0;
int i = 2;

while (i <=numero)
{
    soma += i;
    i = i + 2;
}

Console.WriteLine("A soma dos números pares é: " + soma);