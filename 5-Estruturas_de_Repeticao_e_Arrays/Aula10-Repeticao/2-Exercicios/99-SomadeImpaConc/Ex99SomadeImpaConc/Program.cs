int N = int .Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    int x = int.Parse(valores[0]);
    int y = int.Parse(valores[1]);

    if (x > y)
    {
        int aux = x;
        x = y;
        y = aux;
    }

    int soma = 0;

    for(int cont = x; cont < y; cont++)
    {
        if (cont % 2 != 0)
        {
            soma+= cont;
        }
    }

    Console.WriteLine("Soma dos impares é: "+ soma);
}