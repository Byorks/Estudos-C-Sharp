int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

List<int> num = new List<int>();

for (int i = 0; i <= 10; i++)
{
    num.Add(i);
}


// Length - método mede o tamanho da lista, então independente de quantos itens tenha ele percorrerá toda.
// Melhor para procurar algo especifico na lista, em vez de rodar a lista inteira com foreach

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

// Roda a lista inteira
foreach (var n in numeros)
{
    Console.WriteLine(n);
}