// Um comerciante deseja fazer o levantamento
// do lucro das mercadorias que ele
// comercializa. Para isto, mandou digitar
// um conjunto de N mercadorias, cada uma
// contendo nome, preço de compra e preço de
// venda das mesmas.
// Fazer um programa que leia tais dados e
// determine e escreva quantas mercadorias
// proporcionaram:
// ✓ lucro < 10 %
// ✓ 10 % ≤ lucro ≤ 20%
// ✓ lucro> 20%
// Determine e escreva também o valor total de
// compra e de venda de todas as mercadorias,
// assim como o lucro total.

using System.Globalization;

int entradas = int.Parse(Console.ReadLine());

string[] itemCompraVenda = new string[entradas];

string[] item = new string[entradas];

double[] compra = new double[entradas];

double[] vendas = new double[entradas];

double lucroM10 = 0, lucro1020 = 0, lucroM20 = 0, somaCompras = 0, somaVendas = 0;

// entradas


// Distribuir as listas
for (int i = 0; i < entradas; i++)
{
    itemCompraVenda = Console.ReadLine().Split(' ');

    item[i] = itemCompraVenda[0];
    compra[i] = double.Parse(itemCompraVenda[1], CultureInfo.InvariantCulture);
    vendas[i] = double.Parse(itemCompraVenda[2], CultureInfo.InvariantCulture);
    
    if ( vendas[i] / compra[i] * 100 - 100 > 10 )
    {
        Console.WriteLine("Venda com menos de 10% de lucro");
        lucroM10++;
    }
    else if ( vendas[i] / compra[i] * 100 - 100 >= 10 && vendas[i] / compra[i] * 100 - 100 <= 20)
    {
        Console.WriteLine("Venda com lucro entre 10% e 20%");
        lucro1020++;
    }else
    {
        Console.WriteLine("Venda com mais de 20% de lucro");
        lucroM20++;
    }

    somaCompras += compra[i];
    somaVendas += vendas[i];

}



Console.WriteLine("Lucro abaixo de 10%: " + lucroM10 + "\n Lucro entre 10% e 20%: " + lucro1020 + "\n Lucro acima de 20%: " + lucroM20);
Console.WriteLine("Valor total de compra: " + somaCompras +"\n Valor total vendas: " + somaVendas + "\n Lucro total: " + (somaCompras - somaVendas));


// Conta do % do lucro vai ficar = valor de venda  dividido por valor de compra * 100 - 100