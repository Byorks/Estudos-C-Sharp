static void BarraCarregamento (string texto, int tempo, int quantidade)
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.Write(texto);
    for (int i = 0; i < quantidade; i++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}