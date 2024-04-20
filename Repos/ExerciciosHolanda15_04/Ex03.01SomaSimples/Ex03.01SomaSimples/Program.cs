int soma, primeironum, segundonum;

Console.WriteLine("**** Esse programa soma! ****");

Console.Write("Insira o primeiro número: ");
primeironum = int.Parse(Console.ReadLine());


Console.Write("Insira o segundo número: ");
segundonum = int.Parse(Console.ReadLine());

soma = primeironum + segundonum;

Console.WriteLine("SOMA = " + soma);