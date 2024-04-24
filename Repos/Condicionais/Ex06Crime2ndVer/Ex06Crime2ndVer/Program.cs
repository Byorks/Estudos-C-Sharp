int sim = 0;
// Criando um array  e colocando a largura, 5 iten, para colocar valores depois. 
string[] perguntas = new string[5];

Console.WriteLine("Responda as perguntas com sim ou não.");
perguntas[0] = Console.ReadLine();

// Como crirar um array e colocar um input dentro;
//string[] perguntas = { Console.ReadLine()};

Console.WriteLine("Indice 0 do array perguntas: " + perguntas[0]);
perguntas[0] = Console.ReadLine();

Console.WriteLine("Telefonou para a vítima?");
perguntas[0] = Console.ReadLine();

Console.WriteLine("Esteve no local do crime?");
perguntas[0] = Console.ReadLine();

Console.WriteLine("Mora perto da vítima?");
perguntas[0] = Console.ReadLine();

Console.WriteLine("Devia para a vítima?");
perguntas[0] = Console.ReadLine();

Console.WriteLine("Já trabalhou com a vítima?");
perguntas[0] = Console.ReadLine();



foreach (var item in perguntas)
{
    
}














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