int soma = 0, numeros;

Console.WriteLine("Digite um número, vamos somar (numero negativo para o programa)");
do
{
    numeros = int.Parse(Console.ReadLine());

    Console.WriteLine($"Você digitou : {numeros}");
    soma += numeros;
} while (numeros >= 0);

Console.WriteLine($"Soma = {soma}");