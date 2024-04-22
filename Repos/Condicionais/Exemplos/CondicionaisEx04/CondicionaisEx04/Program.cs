int x, y, z;

// Com auxilio da funcao .Split, separamos os itens em um array
String[] vetor = Console.ReadLine().Split(' ');

x = int.Parse(vetor[0]);
y = int.Parse(vetor[1]);
z = int.Parse(vetor[2]);

if (x < y && x < z)
{
    Console.WriteLine("Menor: " + x);
}
else if (y < z)
{
    Console.WriteLine("Menor: " + y);
}
else
{
    Console.WriteLine("Menor: " +z);
}