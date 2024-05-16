//Leia um valor inteiro N. Este valor será a
// quantidade de valores inteiros X que serão lidos em
// seguida.
// Mostre quantos destes valores X estão dentro do
// intervalo [10,20] e quantos estão fora do intervalo,
// mostrando essas informações

int quantRepeticoes, entrada, dentro = 0, fora = 0;

Console.WriteLine("Digite o número de entradas");
quantRepeticoes = int.Parse(Console.ReadLine());

for (int i = quantRepeticoes; i > 0; i--)
{
    entrada = int.Parse(Console.ReadLine());

    if ( entrada >= 10 && entrada <= 20)
    {
        dentro++;
    }
    else
    {
        fora++;
    }
}

Console.WriteLine("Dentro - " + dentro);
Console.WriteLine("Fora - " + fora);