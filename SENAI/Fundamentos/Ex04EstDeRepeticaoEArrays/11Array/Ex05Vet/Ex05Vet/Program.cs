//Fazer um programa para ler um vetor de
//N números inteiros. Em seguida, mostrar
//na tela a média aritmética somente dos
//números pares lidos.

int entradas = int .Parse(Console.ReadLine());

int[] numLista = new int[entradas];

string[] numListaS = new string[entradas];

numListaS = Console.ReadLine().Split(' ');


int soma = 0, cont = 0;
// for para conversão
// e média aritmética dos pares
for (int i = 0; i < entradas; i++)
{
    numLista[i] = int.Parse(numListaS[i]);

    if (numLista[i] % 2 == 0 )
    {   
        soma += numLista[i];
        cont++;
    }
}

soma /= cont;

Console.WriteLine("Média dos pares = " + soma);


