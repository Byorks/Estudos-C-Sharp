// Faça um programa para ler dois vetores
// A e B, contendo N elementos cada. Em
// seguida, gere um terceiro vetor C onde
// cada elemento de C é a soma dos
// elementos correspondentes de A e B.
// Imprima o vetor C gerado.

Console.WriteLine("Insira o número de entradas");

int entradas = int.Parse(Console.ReadLine());

string[] vetStringA = new string[entradas];

string[] vetStringB = new string[entradas];

int[] vetIntA = new int[entradas];

int[] vetIntB = new int[entradas];

int [] somaVet = new int [entradas];

// for para conversão e fazer a soma no mesmo
for (int i = 0;i < entradas; i++)
{
    vetIntA[i] = int.Parse(vetStringA[i]);
    vetIntB[i] = int.Parse(vetStringB[i]);

    somaVet[i] = vetIntA[i] + vetIntB[i];

    Console.Write(somaVet[i] + " ");
}
