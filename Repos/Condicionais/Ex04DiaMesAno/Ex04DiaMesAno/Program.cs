int dia, mes, ano;
string input;

Console.WriteLine("Digite dia mes e ano, separados por um espaço");
input = Console.ReadLine();

// Com o Split consegue separar a string, e colocar dentro de um array, o parametro de separação fica entre ( ).
string[] valores = input.Split('/');

dia = int.Parse(valores[0]);

mes = int.Parse(valores[1]);

ano = int.Parse(valores[2]);

if (dia > 0 && dia < 32)
{
    if (mes <= 12 && mes > 0)
    {
        if (ano <= 2013 && ano > 1900)
        {
            Console.WriteLine("Data Válida");
            Console.WriteLine($"{dia}/{mes}/{ano} válido");
        }
        else
        {
            Console.WriteLine("Ano Inválido");
        }
    }
    else {
        Console.WriteLine("Mês Inválido");
    }
}
else
{
    Console.WriteLine("Data Inválida");
}

