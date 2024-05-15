string per1,per2,per3,per4,per5;
int sim = 0;
String[] Perguntas; 

Console.WriteLine("Responda as perguntas com sim ou não.");

Console.WriteLine("Telefonou para a vítima?");
per1 = Console.ReadLine();
if (per1 == "sim" || per1 == "Sim"){
    sim++;
}

Console.WriteLine("Esteve no local do crime?");
per2 = Console.ReadLine();

if (per2 == "sim" || per2 == "Sim"){
    sim++;
}

Console.WriteLine("Mora perto da vítima?");
per3 = Console.ReadLine();  
if (per3 == "sim" || per3 == "Sim"){
    sim++;
   }

Console.WriteLine("Devia para a vítima?");
per4 = Console.ReadLine();

if (per4 == "sim" || per4 == "Sim"){
    sim++;
    }

Console.WriteLine("Já trabalhou com a vítima?");
per5 = Console.ReadLine();
if (per5 == "sim" || per5 == "Sim"){
    sim++;
}

if (sim == 2) {
    Console.WriteLine("Você é considerado Suspeito!");
}

else if (sim > 2 && sim <= 4) {

    Console.WriteLine("Você é considerado Cúmplice!");
}

else if (sim >= 5) {
    Console.WriteLine("Você é Culpado!");
}
else
{
    Console.WriteLine("Você é Inocente.");
}

Console.ReadKey();