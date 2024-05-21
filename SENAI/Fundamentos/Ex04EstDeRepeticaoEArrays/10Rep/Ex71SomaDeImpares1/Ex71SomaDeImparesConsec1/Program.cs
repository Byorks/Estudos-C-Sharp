// Leia 2 valores inteiros X e Y. A seguir, calcule e
// mostre a somados números impares entre eles

int numA, numB, soma = 0;

Console.WriteLine("Digite o valor de X: ");
numA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de Y: ");
numB = int.Parse(Console.ReadLine());

if (numB < numA)
{
    int temp = numA;
    numA = numB;
    numB = temp;
}

for (int i = numA + 1; i < numB; i++)
{
    if(i % 2 != 0)
    {   
        soma += i;

        Console.WriteLine("listando impares: " + i);
        Console.WriteLine("listando a soma: " + soma);

    }
}

Console.WriteLine("Valor da soma dos impares = " + soma);
