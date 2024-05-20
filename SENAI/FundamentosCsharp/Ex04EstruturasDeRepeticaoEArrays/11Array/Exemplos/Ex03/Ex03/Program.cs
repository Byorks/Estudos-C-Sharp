using System.Globalization;

int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string[] nomes = new string[n];
int[] idades = new int[n];
double[] alturas = new double[n];

// leitura dos dados
for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split('/');
    nomes[i] = s[0];
    idades[i] = int.Parse(s[1]);
    alturas[i] = double.Parse(s[2]);
}

// calculo da altura media as pessoas
double soma = 0.0;
for (int i = 0; i < n; i++)
{
    soma += alturas[i];
}
Console.WriteLine("Altura média " + soma / n);

// é a mesma coisa que colocar na var e apresentar
double media = soma / n;

//Porcentagem de pessoas abaixo de 16 anos
int cont = 0;
for (int i = 0; i < n; i++)
{
    if (idades[i] < 16)
    {
        cont++;
    }
}
Console.WriteLine("Pessoas com menos de 16 anos " + cont*100/n + " %");