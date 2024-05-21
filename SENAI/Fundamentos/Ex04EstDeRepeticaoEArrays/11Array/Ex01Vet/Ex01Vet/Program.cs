//Faça um programa que leia N números
//reais e armazene-os em um vetor.

//Em seguida, mostrar na tela o maior
//número
//do vetor (supor não haver empates).
//Mostrar também a posição do maior
//elemento.dos valores.
using System.Globalization;

int entradas;


Console.WriteLine("Insira o número de entradas");
entradas = int.Parse(Console.ReadLine());

// criada a lista com o tamanho de entradas
string[] numS = new string[entradas];

// entradas separadas por espaço
numS = Console.ReadLine().Split(' ');

double[] numD = new double[entradas];

// Vai fazer a conversão de string para numeros 
for (int i = 0; i < entradas; i++)
{
    numD[i] = double.Parse(numS[i], CultureInfo.InvariantCulture);
}

// Inicia as variáveis de posição e onde guardarei o maior número
double maior = 0, pos = 0;
for (int i = 0; i < entradas; i++)
{
   if (numD[i] > maior )
    {   
        maior = numD[i];
        pos = i;
    }
}

Console.WriteLine("O maior da lista é " + maior.ToString("F1", CultureInfo.InvariantCulture) + "\nA sua posição é " + pos);

