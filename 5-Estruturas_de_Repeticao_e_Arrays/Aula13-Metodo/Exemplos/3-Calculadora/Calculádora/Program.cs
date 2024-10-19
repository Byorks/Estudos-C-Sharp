static void Menu()
{
    Console.WriteLine("Bem-vindo a Calculadora do Holandinha! Digite qual operação deseja exercutar \n");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair da calculadora");
    Console.WriteLine("\n\n");
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Soma()
{
    Console.Write("\n Primeiro Valor");
    float v1 = float.Parse(Console.ReadLine());
    
    Console.Write("\n" + v1 + " + ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 + v2;
    Console.WriteLine(resultado);

    Console.Clear();
    Console.WriteLine("\nO resultado da soma entre: " + v1 + " + " + v2 + " = " + resultado);
    Console.ReadKey();

    Menu();
}

static void Subtracao()
{
    Console.Write("\n ");
    Console.Write("\n Primeiro Valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("\n" + v1 + " - ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 - v2;
    Console.WriteLine(resultado);

    Console.Clear();
    Console.WriteLine("\nO resultado da subtração entre: " + v1 + " - " + v2 + " = " + resultado);
    Console.ReadKey();

    Menu();

}
static void Multiplicacao()
{
    Console.Write("\n ");
    Console.Write("\n Primeiro Valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("\n" + v1 + " * ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 * v2;
    Console.WriteLine(resultado);

    Console.Clear();
    Console.WriteLine("\nO resultado da multiplicacao entre: " + v1 + " * " + v2 + " = " + resultado);
    Console.ReadKey();

    Menu();

}static void Divisao()
{
    Console.Write("\n ");
    Console.Write("\n Primeiro Valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("\n" + v1 + " / ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 / v2;
    Console.WriteLine(resultado);

    Console.Clear();
    Console.WriteLine("\nO resultado da multiplicacao entre: " + v1 + " / " + v2 + " = " + resultado);
    Console.ReadKey();

    Menu();

}