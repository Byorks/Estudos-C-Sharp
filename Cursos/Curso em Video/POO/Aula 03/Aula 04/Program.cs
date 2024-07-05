using Aula_04;

Caneta c1 = new();

//c1.SetModelo("BIC");
c1.Modelo = "NIC";
//c1.Ponta = 0.6f; Não é possível por conta da proteção
c1.SetPonta(0.5f);

Caneta.MostarPropriedades(c1);

Caneta.MostrarDetalhes(c1);

Console.WriteLine();

Caneta c2 = new();

Caneta.MostrarDetalhes(c2);