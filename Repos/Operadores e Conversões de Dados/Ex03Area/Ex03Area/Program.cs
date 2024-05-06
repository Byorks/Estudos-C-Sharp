using System.Globalization;
double A, B, C;

double[] calculos= new double[5];

string[] formas = { "Triângulo", "Círculo", "Trapézio", "Quadrado", "Retângulo"}; 

double pi = 3.14159;

A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

//Triangulo base A altura C
calculos[0] = (A * C) / 2;

//Area de circulo raio C
calculos[1] = pi * (C * C);

//area do trapézio com A e B por bases e C por altura
calculos[2] = 0.5 * C * (A + B);

// Area do quadrado com lados B
calculos[3] = B * B;

// Area do retângulo com lados A e B
calculos[4] = A * B;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(formas[i] +" = "+ calculos[i].ToString("F3",CultureInfo.InvariantCulture));

}