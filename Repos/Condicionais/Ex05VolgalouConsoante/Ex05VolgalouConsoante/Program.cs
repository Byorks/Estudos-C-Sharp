char input;

Console.WriteLine("**** Esse programa diz se a entrada é vogal ou consoante");
input = char.Parse(Console.ReadLine());

input = char.ToUpper(input);


// Verificação para ver se é número 
//bool Éint = int TryParse(letra, out number);

// Se o bool der positivo, então não entra na comparação, porque a validação é que o bool seja falso
// if ( !Éint )


if (input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U') 
{
    Console.WriteLine($"{input} é vogal");
}
else
{
    Console.WriteLine($"{input} é consoante");
}

// if (String.Equals(letra, "banana", StringComparison.OrdinalIgnoreCase));