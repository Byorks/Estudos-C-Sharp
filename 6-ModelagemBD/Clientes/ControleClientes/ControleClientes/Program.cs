using ControleClientes;

float valPag;

Console.WriteLine("Informe o nome : ");
string nome = Console.ReadLine();

Console.WriteLine("Informe o endereço: ");
string endereco = Console.ReadLine();

Console.WriteLine("Pessoa Fisica(f) ou Juridica(j)? : ");
string tipo = Console.ReadLine();

if (tipo == "f")
{
    PessoaFisica pf = new PessoaFisica();
    pf.Nome = nome;
    pf.Endereco = endereco;
    Console.WriteLine("Informe o CPF: ");
    pf.Cpf = Console.ReadLine();
    Console.WriteLine("Informe o RG: ");
    pf.Rg = Console.ReadLine();
    Console.WriteLine("Informe o valor da compra: ");
    valPag = float.Parse(Console.ReadLine());

    pf.PagarImposto(valPag);

    Console.WriteLine("-------- Pessoa Fisica --------\n");
    Console.WriteLine("Nome .............: " + pf.Nome);
    Console.WriteLine("Endereço..........: " + pf.Endereco);
    Console.WriteLine("CPF...............: " + pf.Cpf);
    Console.WriteLine("RG................: " + pf.Rg);
    Console.WriteLine("Valor da Compra ..:" + pf.Valor.ToString("C"));
    Console.WriteLine("Imposto...........: " + pf.ValorImposto.ToString("C"));
    Console.WriteLine("Total a pagar.....: "  + pf.Total.ToString("C"));


} else if (tipo == "j")
{

    PessoaJuridica pj = new PessoaJuridica();
    pj.Nome = nome;
    pj.Endereco = endereco;
    Console.WriteLine("Informe o CNPJ: ");
    pj.Cnpj = Console.ReadLine();
    Console.WriteLine("Informe o IE: ");
    pj.Ie = Console.ReadLine();
    Console.WriteLine("Informe o valor da compra: ");
    valPag = float.Parse(Console.ReadLine());

    pj.PagarImposto(valPag);

    Console.WriteLine("-------- Pessoa Fisica --------\n");
    Console.WriteLine("Nome .............: " + pj.Nome);
    Console.WriteLine("Endereço..........: " + pj.Endereco);
    Console.WriteLine("CNPJ..............: " + pj.Cnpj);
    Console.WriteLine("IE................: " + pj.Ie);
    Console.WriteLine("Valor da Compra ..: " + pj.Valor.ToString("C"));
    Console.WriteLine("Imposto...........: " + pj.ValorImposto.ToString("C"));
    Console.WriteLine("Total a pagar.....: " + pj.Total.ToString("C"));



}
else
{
    Console.WriteLine("Entrada Inválida");
}