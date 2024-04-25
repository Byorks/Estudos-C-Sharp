using System.Globalization;
int sim = 0, num = 1;
string sims = "sim";

// Criando um array  e colocando a largura, 5 itens, para colocar valores depois. 
string[] perguntas = new string[5];

string[] respostas = new string[5];

Console.WriteLine("Responda as perguntas com sim ou não.");
Console.WriteLine("Vamos começar?");
respostas[0] = Console.ReadLine();

// Como criar um array e colocar um input dentro;
//string[] perguntas = { Console.ReadLine()};

//Teste
Console.WriteLine("Indice 0 do array perguntas: Então " + respostas[0] + "!");

Console.WriteLine("Telefonou para a vítima?");
respostas[0] = Console.ReadLine(), new StringComparison.OrdinalIgnoreCase;

Console.WriteLine("Esteve no local do crime?");
respostas[1] = Console.ReadLine();

Console.WriteLine("Mora perto da vítima?");
respostas[2] = Console.ReadLine();

Console.WriteLine("Devia para a vítima?");
respostas[3] = Console.ReadLine();

Console.WriteLine("Já trabalhou com a vítima?");
respostas[4] = Console.ReadLine();



foreach (string resps in respostas)
{
    
    Console.WriteLine("Resposta n°"+ num +" é: " + resps);
    if (resps == "sim" || resps == "Sim"){
        sim++;
        Console.WriteLine("If Foi Verificado!");
    }
    num++;
}



if (sim == 2)
{
    Console.WriteLine("\nVocê é considerado Suspeito!");
}

else if (sim > 2 && sim <= 4)
{
    Console.WriteLine("\nVocê é considerado Cúmplice!");
}

else if (sim < 4)
{
    Console.WriteLine("\nVocê é Culpado!");
}
else
{
    Console.WriteLine("\n Você é Inocente");
}
Console.ReadKey();