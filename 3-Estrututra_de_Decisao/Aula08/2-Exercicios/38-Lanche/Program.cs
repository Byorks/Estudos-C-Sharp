// Com base na tabela abaixo, escreva um programa que leia o
// código de um item e a quantidade deste item. A seguir, calcule
// e mostre o valor da conta a pagar

Console.WriteLine(
    @"  Código  Especificação      Preço 
        1       Cachorro Quente    R$4.00
        2       X-salada           R$4.50
        3       X-Bacon            R$5.00
        4       Torrada Simples    R$2.00
        5       Refrigerante       R$1.50
"
);

int quantidade, codigo;

// valores


// recebe
string[] valores = Console.ReadLine().Split(' ');

codigo = int.Parse(valores[0]);
quantidade = int.Parse(valores[1]);

double valorTotal = 0;
switch (codigo) { 
    case 1:
        valorTotal = 4.0;
        break;
    case 2:
        valorTotal = 4.5;
        break;
    case 3:
        valorTotal = 5.0;
        break;
    case 4:
        valorTotal = 2.0;
        break;
    case 5:
        valorTotal = 1.5;
        break;
    default:
        Console.WriteLine("Código Inválido \n Produto não existe");
        break;
    }

// calcula
valorTotal *= quantidade;

Console.WriteLine("Total: R$ " + valorTotal.ToString("F2"));



