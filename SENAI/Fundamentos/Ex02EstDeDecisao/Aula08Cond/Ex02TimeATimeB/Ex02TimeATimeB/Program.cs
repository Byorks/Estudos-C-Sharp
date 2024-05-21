int TimeA, TimeB;

Console.WriteLine("Insira os gols do Time A: ");
TimeA = int.Parse(Console.ReadLine());

Console.WriteLine("Insira os gols do Time B: ");
TimeB = int.Parse(Console.ReadLine());

if (TimeA == TimeB) {
    Console.WriteLine("Empate!");
}
else if (TimeA > TimeB)
{
    Console.WriteLine("Time A ganhou!");
}
else
{
    Console.WriteLine("Time B ganhou!");
}