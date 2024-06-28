using Aula_03;

Console.WriteLine("Criando um objeto caneta");

// Instanciando Caneta
Caneta c1 = new Caneta();

c1.Modelo = "BIC Cristal";
c1.Cor = "Azul";
// Ponta está como private, não consigo mais atribuir como antes
//c1.Ponta = 0.5;
// Carga é protected então também não dá certo
//c1.Carga = 99;
//c1.Tampada = true;
c1.Rabiscar();
// Método Private não consigo chamar
// Tampar public, pode alterar o valor de uma propriedade protected
c1.Tampar();

Caneta.MostrarEstadoGetFields(c1);

