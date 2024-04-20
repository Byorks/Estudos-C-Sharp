using System.Globalization; 
int numFuncionario, horas;
double salario;

Console.WriteLine("Insira o numero do funcionario: ");
numFuncionario = int.Parse(Console.ReadLine());

Console.WriteLine("Insira as horas trabalhadas do funcionario: ");
horas = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o salario do funcionario: ");
salario = double.Parse(Console.ReadLine());

salario = horas * salario;

Console.WriteLine("Numero do Funcionario: " + numFuncionario);
Console.WriteLine("Salario: US " + salario.ToString("F2", CultureInfo.InvariantCulture));
