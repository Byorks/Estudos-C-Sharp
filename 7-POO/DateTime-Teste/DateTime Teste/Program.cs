Console.WriteLine("Teste do Método DateTime");

Console.WriteLine();

// Instanciando o objeto 
var date = new DateTime();

// Valor retorna de acordo com a cultura do sistema
Console.Write($"Valor de var date: {date}"); // Saída 01/01/0001 00:00:00

Console.WriteLine("\n Obtendo data e hora atual com DateTime.Now");

var dateNow = DateTime.Now;

Console.Write($"Valo de var dateNow: {dateNow}\n"); // Saída 26/06/2024 10:43:06


Console.WriteLine("Com a variavel var dateNow");
Console.WriteLine(dateNow.ToString("h:mm:ss")); // Saída 10:51:02 
Console.WriteLine("Direto com o objeto DateTime.Now");
Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt")); // Saída 10:51:02 a.m.
Console.WriteLine(dateNow.ToString("d/MM/yyyy"));