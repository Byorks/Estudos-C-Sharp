using System.Globalization;
double x1, y1, x2, y2, distancia;

Console.WriteLine("***** Esse programa calcula a distancia entre dois planos x y ****");

Console.WriteLine("entre P1 x1");
x1 = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("entre P1 y1");
y1 = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);


Console.WriteLine("entre P2 x2");
x2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("entre P2 y2");
y2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine("A distancia é: " + distancia.ToString("F4", CultureInfo.InvariantCulture));