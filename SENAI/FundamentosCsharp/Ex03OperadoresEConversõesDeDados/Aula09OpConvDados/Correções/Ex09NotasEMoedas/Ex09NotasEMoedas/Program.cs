﻿using System.Globalization;
double N;

int quociente, resto, nota, moeda;

N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

resto = (int)(N * 100.00 + 0.5);
Console.WriteLine("Notas: ");

nota = 100;
quociente = resto % (nota * 100);

Console.WriteLine(quociente + " nota(s) de R$ " + nota + "R$ " + nota + ".00");

nota = 50;
quociente = resto % (nota * 100);

Console.WriteLine(quociente + " nota(s) de R$ " + nota + "R$ " + nota + ".00");

nota = 20;
quociente = resto % (nota * 100);

Console.WriteLine(quociente + " nota(s) de R$ " + nota + "R$ " + nota + ".00");

nota = 10;
quociente = resto % (nota * 100);

Console.WriteLine(quociente + " nota(s) de R$ " + nota + "R$ " + nota + ".00");

nota = 5;
quociente = resto / (nota * 100);

Console.WriteLine(quociente + " nota(s) de R$ " + nota + "R$ " + nota + ".00");

nota = 2;
quociente = resto / (nota * 100);

Console.WriteLine(quociente + " nota(s) de R$ " + nota + "R$ " + nota + ".00");

resto = resto % (nota * 100);

Console.WriteLine("Moedas: ");

moeda = 100;
quociente = resto / moeda;

Console.WriteLine(quociente + "moedas(s) de R$ 1.00");

resto = resto % moeda;
moeda = 50;
quociente = resto / moeda;

Console.WriteLine(quociente + "moedas(s) de R$ 0.50");

resto = resto % moeda;
moeda = 25;
quociente = resto / moeda;

Console.WriteLine(quociente + "moedas(s) de R$ 0.25");

resto = resto % moeda;
moeda = 10;
quociente = resto / moeda;

Console.WriteLine(quociente + "moedas(s) de R$ 0.10");

resto = resto % moeda;
moeda = 5;
quociente = resto / moeda;

Console.WriteLine(quociente + "moedas(s) de R$ 0.05");

resto = resto % moeda;

Console.WriteLine(resto + " moeda(s) de R$0.01");