double salario, gasto;

Console.WriteLine("Insira o salário: ");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Insira total gasto: ");
gasto = double.Parse(Console.ReadLine());

if (gasto > salario){
    Console.WriteLine("Orçamento estourado"); 
}
else
{
    Console.WriteLine("Gastos dentro do orçamento");
}