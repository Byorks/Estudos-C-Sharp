using System.Drawing;

double notas100 = 0, notas50 = 0, notas20 = 0, notas10 = 0, notas5 = 0, notas2 = 0, notas1 = 0;
double valor, resto = 0;


Console.WriteLine("Digite o valor");
valor = double.Parse(Console.ReadLine());

//verifica se a nota é maior que 100

if (valor >= 100){
    resto = valor % 100;
    notas100 = valor / 100;
    valor = resto;
}

if (valor >= 50) {
    resto = valor % 50;
    notas50 = valor / 50;
    valor = resto;
}



Console.WriteLine("valor : " + valor + " resto : " + resto);

Console.WriteLine(notas100 + " notas de 100");