//Exercício 5: Verificação de números em ordem crescente

//Escreva um programa que solicita três números ao usuário e verifica se eles estão em ordem crescente. 
//Exibindo uma mensagem indicando se os números estão em ordem crescente ou não.

// Ctrl + KC - para comentar linhas selecionadas
// Ctrl + KU - para descomentar

int numA, numB, numC;
string input;

Console.WriteLine("Insira 3 números separados por um espaço: ");
input = Console.ReadLine();

string[] numeros = input.Split(" ");

numA = int.Parse(numeros[0]);

numB = int.Parse(numeros[1]);

numC = int.Parse(numeros[2]);

if(numA < numB && numB < numC)
{
    Console.WriteLine("Os números estão em ordem crescente.");
}
else if(numA > numB && numB > numC)
{
    Console.WriteLine("Os números estão em ordem descrescente");
}
else
{
    Console.WriteLine("Os números não estão em ordem!");
}


