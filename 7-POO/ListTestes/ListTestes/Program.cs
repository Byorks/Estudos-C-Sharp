Console.WriteLine("Algumas galáxias do nosso universo...\n");

List<string> galaxias = new() { "Via Láctea", "Andrômeda", "Olho Negro", "Sombrero", "Charuto", "Rodamoinho","Cata-Vento","Triângulo","Compasso"};

foreach (string galaxia in galaxias)
{
    Console.Write( galaxia + " ");
}

Console.WriteLine($"\nN° de galáxias: {galaxias.Count}");

Console.WriteLine("\n Inserindo o elemento nos indíces 5,6,7,8 e 9 ");

Console.WriteLine("Pressione algo para iniciar...");
Console.ReadKey();

galaxias.Insert(5, "Bode");
Console.WriteLine("Inserindo Bode no Índice 5");

galaxias.Insert(6, "Cometa");
Console.WriteLine("Inserindo Cometa no Índice 6");

galaxias.Insert(7, "CartWheel");
Console.WriteLine("Inserindo CartWheel no Índice 7");

galaxias.Insert(8, "Girassol");
Console.WriteLine("Inserindo Girassol no Índice 8");

galaxias.Insert(9, "Girino");
Console.WriteLine("Inserindo Girino no Índice 9");

foreach (var i in galaxias)
{
    Console.Write($"{i} ");
}

Console.WriteLine($"\nN° de galáxias: {galaxias.Count}");

Console.ReadKey();
