int senhavalida, senha;

senhavalida = 1234;

Console.Write("Digite a senha: ");
senha = int.Parse(Console.ReadLine());



if (senha == senhavalida)
{
    Console.WriteLine("SENHA VALIDA");
}
else
{
    Console.WriteLine("SENHA INVALIDA");
}