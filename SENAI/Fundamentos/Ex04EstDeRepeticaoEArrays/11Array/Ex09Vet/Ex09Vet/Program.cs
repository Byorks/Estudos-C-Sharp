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
int entradas = int.Parse(Console.ReadLine());

string[] itemCompraVenda = new string[entradas];

string[] item = new string[entradas];

double[] compra = new double[entradas];

double[] vendas = new double[entradas];

// entradas
itemCompraVenda = Console.ReadLine().Split(' ');

// Distribuir as listas
for (int i = 0; i < entradas; i++)
{

}

Console.WriteLine("Teste");
double conta = 4 % 3;

Console.WriteLine("conta = " + conta);