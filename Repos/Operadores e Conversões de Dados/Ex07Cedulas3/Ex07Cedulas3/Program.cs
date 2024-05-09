/* 
 Leia um valor inteiro. A seguir, calcule o menor
número de notas possíveis (cédulas) no qual o valor
pode ser decomposto. As notas consideradas são
de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido
e a relação de notas necessárias.
*/

int valor, nota, resto;

// entra valor
Console.WriteLine("Digite o valor a ser decomposto: ");
valor = int .Parse(Console.ReadLine());

// define a nota atual
nota = 100;
// guarda o que sobra da divisão pelo valor da nota
resto = valor % nota;
// então divide o valor pelo valor da nota, agora valor tem o equivalente a notas que de 100
valor /= nota;
// exibe
Console.WriteLine(valor + " nota(s) de " + nota);
// pega o valor do resto como o valor atual, porque precisamos do que sobrou para continuar calculando
valor = resto;

// começa um novo ciclo, agora com nota de 50
nota = 50;
resto = valor % nota;

valor /= nota;

Console.WriteLine(valor + " nota(s) de " + nota);

valor = resto;

nota = 20;
resto = valor % nota;

valor /= nota;

Console.WriteLine(valor + " nota(s) de " + nota);

valor = resto;

nota = 10;
resto = valor % nota;
valor /= nota;

Console.WriteLine(valor + " nota(s) de " + nota);

valor = resto;

nota = 5;
resto = valor % nota;
valor /= nota;

Console.WriteLine(valor + " nota(s) de " + nota);

valor = resto;

nota = 2;
resto = valor % nota;  
valor /= nota;

Console.WriteLine(valor + " nota(s) de " + nota);

valor = resto;

nota = 1;
valor /= nota;
Console.WriteLine(valor + " nota(s) de " + nota);