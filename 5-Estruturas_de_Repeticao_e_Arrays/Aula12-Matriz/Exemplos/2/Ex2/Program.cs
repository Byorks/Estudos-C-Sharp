int n;
int [,] a;

n = int.Parse(Console.ReadLine());
// instancia o número de linhas e colunas
// Matriz quadrada é o mesmo numero de linhas e colunas
a = new int[n,n];

for ( int i = 0; i < n; i++ )
{
    string[] vet = Console.ReadLine().Split(' ');

    for ( int j = 0; j < n; j++)
    {
        /
        a[i, j] = int.Parse(vet[j]);
    }
}

Console.WriteLine("Diagonal principal: ");
for ( int i = 0; i < n; i++)
{   // mostra a diagonal, por que a diagonal é sempre 00 11 22 33 44 
    Console.WriteLine(a[i, i] + " ");
}
Console.WriteLine();
int cont = 0;

for (int i = 0; i < n ; i++ )
{
    for ( int j = 0;j < n; j++)
    {
        if (a[i, j] < 0)
        {
            cont++;
        }
    }
}
Console.WriteLine("Quantidade de negativos: " + cont);
