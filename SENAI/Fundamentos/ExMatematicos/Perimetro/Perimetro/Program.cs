
double altura, perimetro, area, baseR;

Console.WriteLine("Entre com a base: ");
baseR = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com a altura: ");
altura = double.Parse(Console.ReadLine());

perimetro = 2 * (altura + baseR);
area = baseR * altura;

Console.WriteLine("O perímetro do retângulo é: " + perimetro);
Console.WriteLine("A Área do retângulo é: " + area);
Console.WriteLine("Pressione ENTER para sair...");

Console.ReadKey();
