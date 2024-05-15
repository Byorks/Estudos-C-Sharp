double nota1, nota2, media, peso1, peso2;

peso1 = 3.5;
peso2 = 7.5;

// Da para usar o comando if porque pede de 0 a 10 
Console.WriteLine("Insira a primeira nota: ");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());


nota1 = nota1 * peso1;

nota2 = nota2 * peso2;

media = (nota1 + nota2) / 11;

Console.Write("Media: " +media.ToString("F5"));