//Crie um programa que solicite ao usuário que
//insira uma senha. O programa deve continuar
//pedindo a senha até que o usuário insira a senha
//correta "senha123". Em seguida, exiba uma
//mensagem de boas-vindas.

//bool senhaCorreta = false;

//while (!senhaCorreta) {
//    Console.WriteLine("Digite a senha: ");
//    string senha = Console.ReadLine();

//    if (senha == "senha123")
//    {
//        Console.WriteLine("Seja bem-vindo(a)");
//        senhaCorreta = true;
//    }
//    else
//    {
//        Console.WriteLine("Senha invalida");
//    }
//}

bool senhaCorreta = false;

do
{
    Console.WriteLine("Digite a senha: ");
    string senha = Console.ReadLine();

    if (senha == "senha123")
    {
        Console.WriteLine("Seja bem-vindo(a)");
        senhaCorreta = true;
    }
    else
    {
        Console.WriteLine("Senha invalida");
    }

} while (!senhaCorreta);