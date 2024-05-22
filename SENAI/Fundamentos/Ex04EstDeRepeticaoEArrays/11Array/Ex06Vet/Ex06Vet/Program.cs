//Fazer um programa para ler um
//conjunto de nomes de pessoas e suas
//respectivas idades. Depois, mostrar na
//tela o nome da pessoa mais velha.

int entradas = int .Parse(Console.ReadLine());

string[] listaNomes = new string[entradas];

string[] listaIdadeSt = new string[entradas];

int[] listaIdades = new int[entradas];  

// Entrada de Nomes e Idades
for (int i = 0; i < entradas; i++)
{
    Console.WriteLine("Insira o nome");
    listaNomes[i] = Console.ReadLine();

    Console.WriteLine("Insira a idade");
    listaIdadeSt[i] = Console.ReadLine();

}

int maior = 0, pos = 0;
// Conversão de Idades
for (int i = 0; i < entradas; i++)
{
    listaIdades[i] = int.Parse(listaIdadeSt[i]);

    if (listaIdades[i] > maior)
    {
        maior = listaIdades[i];
        pos = i;
    }

}

Console.WriteLine("A pessoa mais velha é : " + listaNomes[pos]);


// Falta deixar a leitura de nome e idade na mesma linha