using MetodoDasClasses;

Metodos m = new Metodos();
m.Cumprimentar();

// Os valores devem ser do tipo definido na criação do método, e também é possível colocar varíaveis do mesmo tipo
m.Somar(10, 5);

m.Apresentar("Dioguinho", 23);

int valor1 = 100;
int valor2 = 100;

m.AumentarValor(valor1);

// Por referencia deve inserir ref antes do parâmetro
m.AumentarRef(ref valor2);

Console.WriteLine("Valor 1: " +valor1); // Saida - 100
Console.WriteLine("Valor 2: " +valor2); // Saida - 110

Console.ReadKey();