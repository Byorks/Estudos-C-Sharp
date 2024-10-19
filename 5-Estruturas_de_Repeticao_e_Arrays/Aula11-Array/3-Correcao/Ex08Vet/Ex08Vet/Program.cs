// Tem - se um conjunto de dados contendo
// a altura e o sexo (M, F) de N pessoas.
// Fazer um programa que calcule e
// escreva:
// ✓a maior e a menor altura do grupo
// ✓a média de altura das mulheres
// ✓o número de homens

using System.Globalization;

int n = int.Parse(Console.ReadLine());

double[] alturas = new double[n];
char[] sexos = new char[n];

for (int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    alturas[i] = int.Parse(valores[0], CultureInfo.InvariantCulture);
    sexos[i] = char.Parse(valores[1]);
}

double menorAltura = alturas[0];
for (int i = 0;i < n; i++)
{
    if (alturas[i] < menorAltura)
    {
        menorAltura = alturas[i];
    }
}
//double menorAltura = alturas.Min();

double maiorAltura = alturas[0];
for (int i = 0; i < n; i++)
{
    if (alturas[i] > maiorAltura)
    {
        maiorAltura = alturas[i];
    }
}

//double maiorAltura = alturas.Max();

double somaDasAlturas = 0.0;
int contMulheres = 0;
for (int i = 0; i < n; i++)
{
    if (sexos[i] == 'F' || sexos[i] == 'f')
    {
        somaDasAlturas += alturas[i];
        contMulheres++;
    }
    if (contMulheres == 0)
    {
        Console.WriteLine("Nao ha nenhuma mulher entre as pessoas");
    }
    else
    {
        double media = somaDasAlturas / contMulheres;
        Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
}

int numeroDeHomens = n - contMulheres;
Console.WriteLine("Numero de homens: " + numeroDeHomens);