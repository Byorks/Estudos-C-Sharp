int horas; 
Console.WriteLine("Olá, que horas são?");

horas = int.Parse(Console.ReadLine());

// Esse método é bem mais complicado, demanda mais tempo e fica confuso para ler.

if (horas <= 12)
{
    Console.WriteLine("Buenos Dias, Hermano! o(*°▽°*)o");
}
else
{   if (horas < 18)
    {
        Console.WriteLine("Buenas Tardes, Hermano! (^///^)");
    }
    else
    {
        Console.WriteLine("Buenas Noches, Hermano! o(*￣︶￣*)o");
        if (horas < 24)
        {
            Console.WriteLine("Buenas Noches, Hermano! o(*￣︶￣*)o");
        }
        else
        {
            Console.WriteLine("Hora invalida");
        }
    }
}

/** DO WHILE
do
{

} while (true)

**/

// Maneira correta e enchuta;

if (horas <= 12)
{
    Console.WriteLine("Buenos Dias, Hermano! o(*°▽°*)o");
}
else if (horas < 18)
{
    Console.WriteLine("Buenas Tardes, Hermano! (^///^)");
}
else if (horas < 24)
{
    Console.WriteLine("Buenas Noches, Hermano! o(*￣︶￣*)o");
}
else
{
    Console.WriteLine("Hora invalida");
}