using System.Globalization;

double a, b, c, delta, r1,r2;

Console.WriteLine("Insira os valores de a, b e c respectivamente");
String[] vetor = Console.ReadLine().Split(' ');

// O CultureInfo está sendo colocado como cultura inváriavel, para ele ignorar a localização do computador.
a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

// Classe Math com métodos matemáticos que vem para auxiliar
delta = Math.Pow(b, 2.0) - 4 * a * c;

// Se uma das condições forem atendidas, o {} é executado
if (a == 0 && delta < 0.0)
{
    Console.WriteLine("Impossível de Calcular");
}
else
{
    r1 = (-b + Math.Sqrt(delta)) / ( 2.0 * a );
    r2 = (-b + Math.Sqrt(delta)) / ( 2.0 * a );

    Console.WriteLine("R1 = " + r1.ToString("F5",CultureInfo.InvariantCulture));
    Console.WriteLine("R2 = " + r2.ToString("F5",CultureInfo.InvariantCulture));

}

Console.ReadKey();