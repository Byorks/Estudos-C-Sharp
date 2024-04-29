using System.Globalization;
float[] codigo = new float [6];
int quantia;

Console.WriteLine(@" 
    -----------------------------------------
    Codigo |    Especificacao       | Preco
      1    |    Cachorro Quente     | R$ 4.00
      2    |    X-Salada            | R$ 4.50
      3    |    X-Bacon             | R$ 5.00
      4    |    Torrada Simples     | R$ 2.00
      5    |    Refrigerante        | R$ 1.50
           |                        |
    -----------------------------------------
");

codigo[0] = 0;
codigo[1] = 4F;
codigo[2] = 4.5F;
codigo[3] = 5F;
codigo[4] = 2F;
codigo[5] = 1.5F;

Console.WriteLine("Insira o código e a quantidade");
string[] input = Console.ReadLine().Split(' ');

input[0] == input[];

quantia = codigo[int.Parse(input[0]] * int.Parse(input[1]);

Console.WriteLine($"Total a pagar: {quantia.ToString("F2", CultureInfo.InvariantCulture)}");