//Fazer um programa para ler um vetor de
//N números reais. Em seguida, mostrar
//na tela a média aritmética de todos
//elementos.
//Depois mostrar todos os elementos do
//vetor que estejam abaixo da média.
using System.Globalization;
int entradas = int.Parse(Console.ReadLine());

double[] numLista = new double[entradas];

string[] numListaS = new string[entradas];

double[] mediaLista = new double[entradas];

numListaS = Console.ReadLine().Split(' ');

for (int i = 0; i < entradas; i++)
{
    numLista[i] = double.Parse(numListaS[i], CultureInfo.InvariantCulture);
}

double soma = 0;
for (int i = 0; i < entradas; i++)
{
    soma += numLista[i];
}
// Media
soma /= entradas;

Console.WriteLine("Média =  " +  soma.ToString(CultureInfo.InvariantCulture));

Console.WriteLine("Valores abaixo da média: ");
for (int i = 0;i < entradas; i++)
{   
    if (numLista[i] < soma) { 
    
        Console.WriteLine(numLista[i].ToString("F1",CultureInfo.InvariantCulture));
    }
}
