using Aula_03;

Console.WriteLine("Criando um objeto caneta");

// Instanciando Caneta
Caneta c1 = new Caneta();

c1.Cor = "Azul";
c1.Ponta = 0.5;
c1.Tampada = true;
c1.Rabiscar();

Caneta.MostrarEstadoGetFields(c1);

Console.WriteLine();

// Instanciando colocando propriedades com Método Construtor
Caneta c2 = new Caneta("Verde", 50);
c2.Tampar();

Caneta.MostrarEstadoGetFields(c2);
