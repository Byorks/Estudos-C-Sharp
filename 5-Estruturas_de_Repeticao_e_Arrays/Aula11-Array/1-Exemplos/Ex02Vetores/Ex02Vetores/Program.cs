using System.Globalization;

int n = int.Parse(Console.ReadLine());
double[] vetores = new double[n];

string[] s = Console.ReadLine().Split(' ');

// for para leitura
for (int i = 0; i < n; i++)
{   // faz conversão dos valores string para double
    vetores[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
}

// for para mostrar o vetor
for (int i = 0;i < n; i++)
{
    Console.WriteLine(vetores[i] + " ");
    Console.WriteLine();
}

// for para os calculos
double soma = 0.0;
for (int i = 0; i < n; i++)
{
    soma += vetores[i];
}

double media = soma / n;

Console.WriteLine(soma);
Console.WriteLine(media);