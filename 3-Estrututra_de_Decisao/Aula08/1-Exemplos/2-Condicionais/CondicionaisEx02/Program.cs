using System.Globalization;
double nota1, nota2;

Console.Write("Insira a primeira nota: ");
nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Insira a segunda nota: ");
nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

nota1 = nota1 + nota2;

if (nota1 < 60.0)
{
    Console.WriteLine($"Nota Final: {nota1.ToString("F1", CultureInfo.InvariantCulture)}");
    Console.WriteLine("REPROVADO");
}
else
{

    Console.WriteLine($"Nota Final: {nota1}");
}

nota1 = 0;
nota2 = 0;

// Holanda

double soma, nota1, nota2;

nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

soma = nota1 + nota2;

if (nota1 < 60.0)
{
    Console.WriteLine("Nota Final: " + soma.ToString("F1", CultureInfo.InvariantCulture));
    Console.WriteLine("Reprovado");
}
else
{
    Console.WriteLine("Nota Final: " + soma.ToString("F1", CultureInfo.InvariantCulture));
}