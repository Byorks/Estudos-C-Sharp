int A, B, C, D;

Console.WriteLine("Insira 4 números inteiros separados por um espaço");
string input =  Console.ReadLine();

string[] numeros = input.Split(' ');

A = int.Parse(numeros[0]);

B = int.Parse(numeros[1]);

C = int.Parse(numeros[2]);

D = int.Parse(numeros[3]);

if (B > C && D > A)
{    
    int Ctemp = C + D;
    int Atemp = A + B; 
    if (Atemp < Ctemp)
    {
        if (C >= 0 && D >= 0) {
            A %= 2;
            if (A == 0)
            {
                Console.WriteLine("Deu certo");
            } else {
                Console.WriteLine("Ñão deu certo!");
            }
        }
        else
        {
            Console.WriteLine("Não deu certo!");
        }
    }else
    {
        Console.WriteLine("Não deu certo!");
    }
}
else
{
    Console.WriteLine("Não deu certo!");
}