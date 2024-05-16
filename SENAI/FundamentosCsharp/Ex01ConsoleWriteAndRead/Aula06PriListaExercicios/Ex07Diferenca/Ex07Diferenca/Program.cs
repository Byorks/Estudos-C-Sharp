int num1, num2, num3, num4, diferenca;

Console.WriteLine("**** Esse programa calcula a diferença dos produtos 1 e 2 mais 3 e 4 **** ");

Console.WriteLine("Insira o primeiro número: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo número: ");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o terceiro número: ");
num3 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o quarto número: ");
num4 = int.Parse(Console.ReadLine());

num1 = num1 * num2;

num3 = num3 * num4;

diferenca = num1 - num3;

Console.WriteLine("DIFERENÇA = " +  diferenca);