// Faça um programa que leia N números
// inteiros e armazene-os em um vetor. Em
// seguida, mostre na tela:
// - todos os números pares
// - a quantidade de números pares

Console.WriteLine("Insira o número de leituras : ");
int nLeituras = int.Parse(Console.ReadLine());

// array de int
int[] vetor = new int[nLeituras];

// array de strings
string[] vetorS = new string[nLeituras];

// Separa as strings em cada index o parametro de separação é o espaço
vetorS = Console.ReadLine().Split(' ');

// for de conversão
for (int i = 0; i < nLeituras; i++)
{
    vetor[i] = int.Parse(vetorS[i]);

}

int cont = 0;

Console.WriteLine("Números pares da lista são: ");
for (int i = 0;i < nLeituras; i++)
{
    if (vetor[i] % 2 == 0)
    {   

        Console.Write(vetor[i] + " ");
        cont++;
    }
}

Console.WriteLine("Número de pares é: " + cont);




