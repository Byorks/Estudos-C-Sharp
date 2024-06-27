using TipoDelegate;

Matematica m = new Matematica();

Operacao conta = null;
// Variável que faz refêrencias de métodos
// Mas os métodos precisam ter o mesmo tipo de assinatura e retorno
// Aqui só estou atribuindo a refêrencia do método que tem a mesma refêrencia do método delegate
conta += m.Somar; // Saída 20
conta += m.Subtrair; // Saída 0
conta += m.Multiplicar; // Saída 100
conta += m.Multiplicar; // Saída 
conta += m.Dividir; // Saída 1

// Excuta todas as operações 

conta(10, 10);

Console.WriteLine();

// Retirando Divisão e Subtração
conta -= m.Dividir;
conta -= m.Subtrair;

conta(15, 3);

// Saída 18
// Saída 45
// Saída 45

Console.ReadKey();