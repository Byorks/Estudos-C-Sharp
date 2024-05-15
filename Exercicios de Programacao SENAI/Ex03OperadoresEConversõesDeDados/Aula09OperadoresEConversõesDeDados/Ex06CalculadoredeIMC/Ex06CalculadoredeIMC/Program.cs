using System.Globalization;
double peso, altura, IMC;

Console.WriteLine("**** Calculdadora de IMC ****");

Console.Write("Nome: ");
Console.ReadLine();

Console.Write("Peso: ");
peso = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.Write("Altura: ");
altura = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

IMC = peso / (altura * altura);

IMC = Math.Round(IMC, 2);
Console.WriteLine("Seu índice de massa corporal é: " + IMC);