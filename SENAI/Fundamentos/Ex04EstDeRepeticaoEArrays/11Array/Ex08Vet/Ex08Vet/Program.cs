// Tem - se um conjunto de dados contendo
// a altura e o sexo (M, F) de N pessoas.
// Fazer um programa que calcule e
// escreva:
// ✓a maior e a menor altura do grupo
// ✓a média de altura das mulheres
// ✓o número de homens

int entradas = int.Parse(Console.ReadLine());

string[] entradaAltSex = new string[entradas];

string[] sexo = new string[entradas];

double[] altura = new double[entradas];

// dividir
for (int i = 0; i < entradas; i++)
{
    entradaAltSex = Console.ReadLine().Split(' ');

    altura[i] = double.Parse(entradaAltSex[0]);

    sexo[i] = entradaAltSex[1];
}

// maior e menor
double maior = 0, menor = altura[0], posMa = 0, posMe = 0;
for (int i = 0; i < entradas; i++)
{
    if (altura[i] > maior)
    {
        maior = altura[i];
        posMa = i;
    }
    if (altura[i] < menor)
    {
        menor = altura[i];

        posMe = i;
    }

}

Console.WriteLine("Menor altura: " +)