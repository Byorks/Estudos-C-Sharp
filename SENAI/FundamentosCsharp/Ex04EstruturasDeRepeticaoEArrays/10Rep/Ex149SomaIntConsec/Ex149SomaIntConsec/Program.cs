int A, N, soma = 0;

string[] entrada = Console.ReadLine().Split(' ');

A = int.Parse(entrada[0]);

N = int.Parse(entrada[1]);

soma = A;

while (N <= 0)
{
    Console.WriteLine("Digite o valor de N");
    N = int .Parse(Console.ReadLine());

}

for (int i = 0; i < N; i++)
{
    A += i;
}
soma += A;

Console.WriteLine("Soma é : " + soma);