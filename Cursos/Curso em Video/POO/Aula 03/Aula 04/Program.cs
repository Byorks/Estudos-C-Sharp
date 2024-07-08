using Aula_04;

#region Aula 04 Criando Caneta Get Set e private e public
Caneta c1 = new();

//c1.SetModelo("BIC");
c1.Modelo = "NIC";
//c1.Ponta = 0.6f; Não é possível por conta da proteção
c1.SetPonta(0.5f);

Caneta.MostrarPropriedades(c1);

Console.WriteLine();

Caneta c2 = new("BIC", "Vermelha", 0.7f);

Caneta.MostrarPropriedades(c2);
c2.GetPonta();

Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();
Console.Clear();

#endregion

#region Exercício A4 Criando Objeto Simples
Console.WriteLine("Criando Objeto Microfone");
    
#endregion