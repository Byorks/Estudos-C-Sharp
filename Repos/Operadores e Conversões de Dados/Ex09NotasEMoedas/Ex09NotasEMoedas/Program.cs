using System.Globalization;
float valor, moedas, nota, sobra;
int valorInt;

Console.WriteLine("Insira o valor a ser fracionado em cédulas e moedas: ");
valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

nota = 100F;
sobra = (valor % nota) * 100;
valor = Math.Round(valor / nota);

Console.WriteLine(valor + " Nota(s) de " + nota);

valor = sobra;