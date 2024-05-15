int num1, num2, prod;

Console.WriteLine(" *** Esse programa calcula o produto de dois números! ***");

Console.Write("Insira o primeiro númmero: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Insira o segundo númmero: ");
num2 = int.Parse(Console.ReadLine());

prod = num1 * num2;

Console.WriteLine("PROD = " + prod);