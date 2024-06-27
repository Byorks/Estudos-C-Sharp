using ThermoThis;

Acessar a = new Acessar();

if (a.Login("abc123"))
{
    Console.WriteLine("Seja bem vindo !");
}
else
{
    Console.WriteLine("Acesso negado !");
}