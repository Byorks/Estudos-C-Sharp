bool loop = true;
string palavra;
char[] palavraInvertida = new char
while (loop)
{
    Console.WriteLine("Vamos verificar se a palavra e um palindromo");
    Console.WriteLine("Digite uma palavra");
    palavra = Console.ReadLine();



    Console.WriteLine($"A palavra original: {palavra}");
    Console.WriteLine($"A palavra invertida: {palavraInvertida}");

    Console.WriteLine("Quer continuar o loop?");
    int confirm = int .Parse(Console.ReadLine());
    if(confirm == 0)
    {
        loop = false;
    }


}