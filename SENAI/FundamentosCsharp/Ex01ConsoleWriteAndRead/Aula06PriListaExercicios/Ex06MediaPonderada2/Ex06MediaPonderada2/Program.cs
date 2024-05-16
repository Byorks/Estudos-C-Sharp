double nota1, nota2, nota3, media;

Console.WriteLine("Insira a primeira nota: ");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a terceira nota: ");
nota3 = double.Parse(Console.ReadLine());

nota1 = nota1 * 2;

nota2 = nota2 * 3;

nota3 = nota3 * 5;

media = (nota1 + nota2 + nota3) / 10;

Console.Write("MEDIA = " +media.ToString("F1"));

Console.ReadKey();