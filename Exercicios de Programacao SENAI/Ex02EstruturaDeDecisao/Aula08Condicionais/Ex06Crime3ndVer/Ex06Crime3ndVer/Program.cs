int sim;
string[] perguntas = new string[5];
string[] respostas = new string[5];

perguntas[0] ="Telefonou para a vítima?";
perguntas[1] ="Esteve no local do crime?";
perguntas[2] ="Mora perto da vítima?";
perguntas[3] ="Devia para a vítima?";
perguntas[4] ="Já trabalhou com a vítima?";

sim = 0;

Console.WriteLine("responda com sim ou não");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(perguntas[i]);
    respostas[i] = Console.ReadLine();
    // lembrar de falar qual é o tipo de objeto que queremos comparar no Equals, antes dos .Equals
    if (string.Equals(respostas[i], "sim", StringComparison.OrdinalIgnoreCase))
    {   
        sim++;
    }
}

if  (sim == 2)
{
    Console.WriteLine("Você é suspeito!");
}
else if (sim == 3 || sim == 4)
{
    Console.WriteLine("Você é cumplice!");
}
else if (sim >= 5)
{
    Console.WriteLine("Você é culpado!");
}
else
{
    Console.WriteLine("Você é inocente");
}

switch (sim)
{


    case 2: Console.WriteLine("Você é suspeito");
        break;
    case 3:
        Console.WriteLine("Você é cumplice");
        break;
    case 4:
        Console.WriteLine("Você é cumplice");
        break;
    case 5:
        Console.WriteLine("Você é culpado!");
        break;
    default:
        Console.WriteLine("Você é inocente");
        break;

}