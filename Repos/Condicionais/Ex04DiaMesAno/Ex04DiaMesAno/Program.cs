int dia, mes, ano;

Console.WriteLine("Digite dia mes e ano, separados por um espaço");
dia = int.Parse(Console.ReadLine());

mes = int.Parse(Console.ReadLine());

ano = int.Parse(Console.ReadLine());

if (dia > 0 && dia < 32){
    if (mes > 12 && mes < 0)
    {
        if (ano >= 2013)
        {
            Console.WriteLine("Data Valida");
            Console.WriteLine($"{dia} {mes} {ano} valido");
        }
    }
    else {
        Console.WriteLine("Data Invalida");
    }
}
else
{
    Console.WriteLine("Data Invalida");
}

