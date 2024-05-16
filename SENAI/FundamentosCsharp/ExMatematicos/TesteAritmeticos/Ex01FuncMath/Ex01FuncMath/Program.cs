using System.Globalization;
double b, a, area, perimetro, diagonal;

b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);   
a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

area = b * a;

perimetro = 2 * (b + a);

//Sqrt raiz quadrada
diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Perimentro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Diagonoal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));