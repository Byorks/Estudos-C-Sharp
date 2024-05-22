// Fazer um programa para ler um
// conjunto de N nomes de alunos, bem
// como as notas que eles tiraram no 1o e 2o
// semestres.
// Cada uma dessas informações deve ser
// armazenada em um vetor.
// Depois, imprimir os nomes dos alunos
// aprovados,
// considerando aprovado aqueles cuja
// média das notas seja maior ou igual a
// seis.

using System.Globalization;

int entradas = int.Parse(Console.ReadLine());

string[] entradasNomesNotas = new string[entradas];

string[] listaNomes = new string[entradas];

double[] notasA = new double[entradas];

double[] notasB = new double[entradas];


// for para split, divisão
for (int i = 0; i < entradas; i++)
{
    entradasNomesNotas = Console.ReadLine().Split(' ');

    listaNomes[i] = entradasNomesNotas[0];
    notasA[i] = double.Parse(entradasNomesNotas[1], CultureInfo.InvariantCulture);
    notasB[i] = double.Parse(entradasNomesNotas[2], CultureInfo.InvariantCulture);
}

// Aprovados
double media = 0;
Console.WriteLine("Lista de aprovados: ");
for (int i = 0; i < entradas; i++)
{
    media = (notasA[i] + notasB[i]) / 2;

    if (media >= 6)
    {
        Console.WriteLine(listaNomes[i]);
    }
}
