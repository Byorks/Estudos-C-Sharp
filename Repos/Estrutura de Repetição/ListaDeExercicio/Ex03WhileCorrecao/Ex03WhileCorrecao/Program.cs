Console.WriteLine("Digite uma palavra: ");
string palavra = Console.ReadLine().ToLower();

int i = 0;
int j = palavra.Length;
bool ehPalindromo = true;

while (i < j)
{
    if (palavra[i] != palavra[j])
    {
        ehPalindromo = false;
    break;

    }
    Console.WriteLine(palavra[i]);
    Console.WriteLine(palavra[j]);
    i++;
    j--;
}

if (ehPalindromo)
{
    Console.WriteLine("A palavra é um palindromo");
}
else
{
    Console.WriteLine("a palavra não é um palindromo");
}