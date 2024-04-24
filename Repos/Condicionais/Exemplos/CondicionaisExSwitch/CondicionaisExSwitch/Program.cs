

string fruta = Console.ReadLine();

switch (fruta)
{	// caso fruta seja banana
	case "banana":
		Console.WriteLine("Bananas custam R$10 a dúzia");
		break;
	case "uva":
		Console.WriteLine("Uvas custam R$20 a dúzia");
		break;
	case "maçã":
		Console.WriteLine("Uvas custam R$15 a dúzia");
		break;
	default:
		Console.WriteLine("Não temos essa fruta");
		break; // Se não for bananas, maçãs ou uvas
}