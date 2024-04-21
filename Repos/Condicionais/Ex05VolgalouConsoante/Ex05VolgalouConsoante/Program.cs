char input;

Console.WriteLine("**** Esse programa diz se a entrada é vogal ou consoante");
input = char.Parse(Console.ReadLine());

input = char.ToUpper(input);

if (input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U') 
{
    Console.WriteLine($"{input} é vogal");
}
else
{
    Console.WriteLine($"{input} é consoante");
}
