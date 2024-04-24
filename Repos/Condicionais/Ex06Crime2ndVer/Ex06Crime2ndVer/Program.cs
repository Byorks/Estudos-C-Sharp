int sim = 0;
String[] perguntas;

Console.WriteLine("Responda as perguntas com sim ou não.");
perguntas = Console.ReadLine();

Console.WriteLine("Telefonou para a vítima?");


Console.WriteLine("Esteve no local do crime?");

Console.WriteLine("Mora perto da vítima?");

Console.WriteLine("Devia para a vítima?");


Console.WriteLine("Já trabalhou com a vítima?");


















if (sim == 2)
{
    Console.WriteLine("Você é considerado Suspeito!");
}

else if (sim > 2 && sim <= 4)
{

    Console.WriteLine("Você é considerado Cúmplice!");
}

else if (sim == 5)
{
    Console.WriteLine("Você é Culpado!");
}

Console.ReadKey();