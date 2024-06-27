using MetodoDasClasses;

Metodos m = new Metodos();

#region Método Simples
//m.Cumprimentar();
#endregion

#region Método com Parâmetros
// Os valores devem ser do tipo definido na criação do método, e também é possível colocar varíaveis do mesmo tipo
//m.Somar(10, 5);

//m.Apresentar("Dioguinho", 23);
//#endregion

#region Passagem de parâmetro por valor e referência
//int valor1 = 100;
//int valor2 = 100;

//m.AumentarValor(valor1);

//// Por referencia deve inserir ref antes do parâmetro
//m.AumentarRef(ref valor2);

//Console.WriteLine("Valor 1: " +valor1); // Saida - 100
//Console.WriteLine("Valor 2: " +valor2); // Saida - 110
#endregion

#region Método com Retorno de Valores

//string nomeCompleto = m.MontaNome("Vanessa", "Ferreira");
//int codigoChar = m.CodigoChar('a'); // Retorna o código do char 'a'  -> 97
//double Pi = m.ValorPi();

//Console.WriteLine("Método com dois parâmetros tipo string e o retorno é string: " + nomeCompleto);
//Console.WriteLine("Método com parâmetro char e retorno int: " + codigoChar);
//Console.WriteLine("Método sem parâmetro e com retorno double: " + Pi);

//Console.ReadKey();
#endregion

#region MyRegion
m.Cumprimentar();
m.Cumprimentar("Vanessa Byork");
m.Cumprimentar("Vanessa Byork", 18);

bool res1 = m.Comparar(100, 50 * 2); // true
bool res2 = m.Comparar("Vanessa Byork", "vanessa byork"); // false porque é case sensitive 

Console.WriteLine(res1);
Console.WriteLine(res2); 

#endregion

Console.ReadKey();