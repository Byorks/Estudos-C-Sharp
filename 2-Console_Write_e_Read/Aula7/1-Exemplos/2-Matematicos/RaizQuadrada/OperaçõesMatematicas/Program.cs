Console.WriteLine("********  Descubra a Raís Quadrada de um Número!!! ********\n");
Console.Write("Entre com o valor de um número para calcular a Raíz: ");

double x = double.Parse(Console.ReadLine());
double y = Math.Sqrt(x);

Console.WriteLine("A raiz quadrada de " + x + " é igual a: " + y);
Console.WriteLine("Pressione qualquer tecla para sair (⌐■_■)");

Console.ReadKey();