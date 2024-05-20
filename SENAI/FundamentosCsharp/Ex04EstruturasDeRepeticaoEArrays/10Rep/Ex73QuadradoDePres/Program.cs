// Leia um valor inteiro N. Apresente o quadrado de
// cada um dos valores pares, de 1 até N, inclusive N,
// se for o caso.

int numA = 1;

while (!(5 < numA && numA < 2000))
{
    Console.WriteLine("Insira o valor de N");
    numA = int .Parse(Console.ReadLine());

}

for (int i = 1; i <= numA; i ++)
{
    if (i % 2 == 0)
    {   
        int quadrado = i * i;
        Console.WriteLine($"{i} ^ 2 = {quadrado}");
    }
}