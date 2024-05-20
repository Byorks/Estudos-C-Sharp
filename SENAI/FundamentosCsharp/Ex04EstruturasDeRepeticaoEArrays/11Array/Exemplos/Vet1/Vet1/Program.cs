int n = int.Parse(Console.ReadLine());
// Coloca o valor de n no valor do tamanho do array
double[] vetor = new double[n];

// Limita o tamanho do for para o tamanho de n
for (int i = 0; i < n; i++)
{
    vetor[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine(vetor[i]);
}