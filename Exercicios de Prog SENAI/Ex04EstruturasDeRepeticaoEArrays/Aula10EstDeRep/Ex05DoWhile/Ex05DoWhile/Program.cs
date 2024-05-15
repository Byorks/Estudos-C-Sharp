int soma = 0, numeros;

Console.WriteLine("Digite um número, vamos somar (numero negativo para o programa)");
do
{
    numeros = int.Parse(Console.ReadLine());

    Console.WriteLine($"Você digitou : {numeros}");

    if( numeros > 0 ){ 
        soma += numeros;
    }
    Console.WriteLine(soma);

} while (numeros >= 0);

Console.WriteLine($"Soma dos positivos = {soma}");