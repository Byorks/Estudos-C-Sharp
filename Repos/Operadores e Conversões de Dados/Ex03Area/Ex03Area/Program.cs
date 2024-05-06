double A, B, C;

double[] calculos= new double[5];

double pi = 3.14159;

A = double.Parse(Console.ReadLine());

B = double.Parse(Console.ReadLine());

C = double.Parse(Console.ReadLine());

//Triangulo base A altura C
calculos[0] = (A * C) / 2;

//Area de circulo raio C
calculos[1] = pi * (C * C);

//area do trapézio com A e B por bases e C por altura
calculos[2] = ((A * B )/ 2) * C;

