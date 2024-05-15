//Crie um programa que gere um número aleatório
//entre 1 e 100 e, em seguida, permita ao usuário
//adivinhar o número. O programa deve informar se
//o número inserido é maior ou menor que o
//número gerado até que o usuário adivinhe
//corretamente.
using System;
using System.Security.Cryptography;

int randNum, num, cont = 0;
//RandomNumberGenerator

// instanciei uma classe random e useu o metodo next
randNum = new Random().Next(101);

do {
    cont++;

    Console.WriteLine("Tente advinhar o número (entre 1 e 100)");
    num = int.Parse(Console.ReadLine());
    
    if(num < randNum)
    {
        Console.WriteLine("Digite um número maior!\n");
    }
    else if (num > randNum)
    {
        Console.WriteLine("Digite o número menor!\n");
    }
    else
    {
        Console.WriteLine("\nVocê acertou!!!");
    }
}while (num != randNum);

Console.WriteLine($"Você adivinhou o numero em {cont} tentativas");
Console.WriteLine("Fim do programa");