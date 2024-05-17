int numA, numB = 0, maior = 0, pos = 0, posSalva = 0;

for  (int i = 1; i <= 10; i++)
{
    numA = int .Parse(Console.ReadLine());


    pos++;

    if (numA > numB)
    {
        maior = numA;
        posSalva = pos;
    }

    numB = numA;
}
Console.WriteLine("O maior é :" + maior + " posição" + posSalva);