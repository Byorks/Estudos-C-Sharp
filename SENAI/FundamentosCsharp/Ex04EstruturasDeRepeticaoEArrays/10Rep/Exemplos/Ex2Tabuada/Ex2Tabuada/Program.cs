int n;

n = int.Parse(Console.ReadLine());

// i conta , entra a comparação, e soma no i, repetindo até a condição não ser atendida
for (int i = 1; i <= 10; i++)
{
    int resultado = i * n;
    Console.WriteLine(i + " * " + n + " = " + resultado);
}