using System.Globalization;
string nome;
double salariofixo, totalvendas, ganhodomes;

Console.Write("Insira o nome: \n");
nome = Console.ReadLine();

Console.Write("Insira o salario mensal:\n");
salariofixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Insira o ganho do mes\n");
totalvendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

ganhodomes = salariofixo + (totalvendas * 15 / 100);

Console.WriteLine("Total: "+ ganhodomes.ToString("F2", CultureInfo.InvariantCulture));

