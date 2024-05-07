int A, B, C, MaiorAB, MaiorBC;
string valores;

Console.WriteLine("**** Esse programa verifica o maior número entre três valores ****");

Console.WriteLine("Digite três números separados por um espaço");
valores = Console.ReadLine();

string[] valorel = valores.Split(' ');

// Duas formas diferentes de converter
A = int.Parse(valorel[0]);

B = Convert.ToInt32(valorel[1]);

C = Convert.ToInt32(valorel[2]);

MaiorAB = (A + B + Math.Abs(A - B)) / 2;

MaiorBC = (C + MaiorAB + Math.Abs(C - MaiorAB)) / 2;

Console.WriteLine("Maior entre A e B é: " + MaiorAB);

Console.WriteLine(MaiorBC + " é o maior");