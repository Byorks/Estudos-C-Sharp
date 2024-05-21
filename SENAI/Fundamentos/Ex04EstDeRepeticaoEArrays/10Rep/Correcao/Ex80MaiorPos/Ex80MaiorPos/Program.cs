int x, numB, maior = 0, pos = 0, posSalva = 0;

for  (int i = 1; i <= 10; i++)
{
    x = int .Parse(Console.ReadLine());

    if (x > maior)
    {
        maior = x;
        posSalva = i;
    }

}
Console.WriteLine("O maior é :" + maior + " posição: " + posSalva);