int distanciaper;
double totalgasolinagasta, totalgasto;
Console.WriteLine("**** Esse programa fornece o consumo médio de um automóvel ****");

Console.WriteLine("Insira a distância percorrida em km");
distanciaper = int.Parse(Console.ReadLine());

Console.WriteLine("Insira a quantidade gasta de gasolina");
totalgasolinagasta = double.Parse(Console.ReadLine());


totalgasto = distanciaper / totalgasolinagasta;

// Como escrever a variavel onde desejar, método Interpolação de String
Console.WriteLine($"O consumo médio é {totalgasto:F3} km/1");

// Como escrever, método Concatenação de Strings
Console.WriteLine(totalgasto.ToString("F3") + " Km/1");

Console.ReadKey();