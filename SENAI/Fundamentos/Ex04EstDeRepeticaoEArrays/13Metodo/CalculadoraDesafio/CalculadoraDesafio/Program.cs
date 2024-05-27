﻿// Fazer as funções 

// F Soma e exibir o resultado
static double Soma(double numA, double numB)
{
    double soma = numA + numB;
    return soma;
}
// F Subtracao e exibir o resultado
static double Subtracao(double numA, double numB)
{
    double subtracao = numA - numB;
    return subtracao;
}

// F Divisao e exibir o resultado - cuidado para evitar div com 0
static double Divisao(double numA, double numB)
{
    double div = numA / numB;

    if ( numB == 0 ) {
        div = 0;
        return div;
    }
    return div;
}

// F Multiplicacao e exibir o resultado

static double Multiplicacao (double numA, double numB)
{
    double multi = numA * numB;
    return multi;
}


double numeroX, numeroY, resultado;

// Criar menu
bool menu = true;
string operacao;

while (menu)
{
    Console.WriteLine("Calculadora \n Digite sua opção desejada \n 1 - Soma \n 2 - Subtração \n 3 - Divisão \n 4 - Multiplicação \n Digite sair para parar o programa :3");
    operacao = Console.ReadLine();
    switch (operacao.ToLower())
    {   
        case "1":
            Console.WriteLine("Você escolheu soma");
            Console.WriteLine("Digite o primeiro número: ");
            numeroX = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numeroY = double.Parse(Console.ReadLine());

            resultado = Soma(numeroX, numeroY);

            Console.WriteLine("Soma = " + resultado);

            Console.ReadKey();
            Console.Clear();
            break;


        case "2":
            Console.WriteLine("Você escolheu subtração");

            Console.WriteLine("Digite o primeiro número: ");
            numeroX = double.Parse(Console.ReadLine());
             
            Console.WriteLine("Digite o segundo número: ");
            numeroY = double.Parse(Console.ReadLine());

            resultado = Subtracao(numeroX, numeroY);

            Console.WriteLine("Subtração = " + resultado);
            
            Console.ReadKey();
            Console.Clear();

            break;

        case "3":
            Console.WriteLine("Você escolheu divisão");

            Console.WriteLine("Digite o primeiro número: ");
            numeroX = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numeroY = double.Parse(Console.ReadLine());

            while (numeroY == 0)
            {   
                Console.WriteLine("Não é possível dividir por 0");
                Console.WriteLine("Digite o segundo número: ");
                numeroY = double.Parse(Console.ReadLine());
            }

            resultado = Divisao(numeroX, numeroY);

            Console.WriteLine("Divisão = " + resultado);

            Console.ReadKey();
            Console.Clear();

            break;

        case "4":
            Console.WriteLine("Você escolheu multiplicação");

            Console.WriteLine("Digite o primeiro número: ");
            numeroX = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numeroY = double.Parse(Console.ReadLine());

            resultado = Multiplicacao(numeroX, numeroY);

            Console.WriteLine("Multiplicação = " + resultado);

            Console.ReadKey();
            Console.Clear();
            break;


        case "sair":
            menu = false;
            break;



    }


}



// criar jeito de limpar depois da execucao

//Ter While para voltar ao menu

//Se digitar "sair" ou similar, sair do programa
