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

int n = int.Parse(Console.ReadLine());

string[] item = new string[n];
double[] compra = new double[n];
double[] vendas = new double[n];




// Distribuir as listas
for (int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split(' ');

    item[i] = valores[0];
    compra[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
    vendas[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);

}

int contAbaixoDe10 = 0;
int contEntre10e20 = 0;
int contAcimaDe20 = 0;

for (int i = 0; i < n; i++)
{
    double lucro = vendas[i] - compra[i];
    double porcentagemDeLucro = lucro / compra[i] * 100.0;

    if ( porcentagemDeLucro < 10.0 )
    {
        contAbaixoDe10++;

    }else if ( porcentagemDeLucro <= 20.0)
    {
        contEntre10e20++;
    }else
    {
        contAcimaDe20++;
    }
}

Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10e20);
Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);


double totalCompra = 0.0;
double totalVenda = 0.0;

for (int i = 0; i < n;i++)
{
    totalCompra += compra[i];
    totalVenda += vendas[i];
}

double totalLucro = totalVenda - totalCompra;

Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));


