using ClassesObjetos;

#region Classes e Objetos

/*
// Criando objetos 

// Instanciando/Criando um novo objeto
MinhaClasse mClasse = new MinhaClasse();

// Posso definir um objeto sem um valor atribuído inicialmente
MinhaClasse m2 = null;

// Só pode instanciar para o mesmo tipo
OutraClasse outra = new OutraClasse();

// Mas posso passar a referencia da var para outra var
OutraClasse outra2 = outra;
*/
#endregion

// Atributos das Classes / Atribuindo Caracteristicas

// atribuindo propriedades mencionando o Atributo
Pessoa pessoa1 = new Pessoa();
pessoa1.nome = "Vanessa Byork";
pessoa1.sobrenome = "Pinto";
pessoa1.anoNascimento = 1999;

// Definindo os camnpos sem referenciar, na própria instanciação
Pessoa pessoa2 = new Pessoa()
{
    nome = "Diogo",
    sobrenome = "Botton",
    anoNascimento = 2000

};

Console.WriteLine("Pessoa 1: " + pessoa1.nome);
Console.WriteLine("Pessoa 1: " + pessoa1.sobrenome);
Console.WriteLine("Pessoa 1: " + pessoa1.anoNascimento);
pessoa1.Cumprimentar();

Console.WriteLine();

Console.WriteLine("Pessoa 2: " + pessoa2.nome);
Console.WriteLine("Pessoa 2: " + pessoa2.sobrenome);
Console.WriteLine("Pessoa 2: " + pessoa2.anoNascimento);
pessoa2.Cumprimentar();

Console.ReadKey();

// Posso mudar o atributo a qualquer momento
pessoa1.sobrenome = "Ferreira";


Console.WriteLine();

Console.WriteLine("Pessoa 2 :" + pessoa1.nome);
Console.WriteLine("Pessoa 2 " + pessoa1.sobrenome);

Console.ReadKey();