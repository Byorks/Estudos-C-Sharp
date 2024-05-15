double valor, saldo, resto;
double notas100 = 0, notas50 = 0, notas20, notas10, notas5, notas2, notas1;

Console.WriteLine("Ínsira o valor: ");
valor = double.Parse(Console.ReadLine());

saldo = valor;

if (valor >= 100){

    resto = valor % 100;

    if (resto == 0){
        notas100 = valor / 100;
        Console.WriteLine(notas100 + " notas de 100");
    }
    else
    {
        notas100 = Math.Round(valor / 100);
        Console.WriteLine(notas100 + " notas de 100");

        valor -= (100 * notas100);

    }
}

if (valor >= 50)
{

    resto = valor % 50;

    if (resto == 0)
    {
        notas50 = valor / 50;
    }
}


Console.WriteLine(notas50 + " notas de 50");

Console.WriteLine("Esse é o valor da var valor: " + valor);