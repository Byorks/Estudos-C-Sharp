int linha, coluna;
int[,] a;

// entrada de linhas e colunas
string[] s = Console.ReadLine().Split(' ');

linha = int.Parse(s[0]); 
coluna = int.Parse(s[1]);   

// instanciou com base nos números recebidos
a = new int [linha, coluna];

//
for (int i = 0; i < linha; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < coluna; j++)
    {
        a[i, j] = int.Parse(vet[j]);
    }
}

Console.WriteLine();

for (int i = 0; i < linha; i++)
{

    for (int j = 0; j < coluna; j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
