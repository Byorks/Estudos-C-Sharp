int kmpercorridos;

Console.WriteLine("**** Esse programa calcula a distancia entre dois carroas X corre a 60km/h e Y a 90km/m e mostra a quantos minutos de distancia o carro Y está do X ****");

Console.Write("Insira quantos Km o carro X percorreu: ");
kmpercorridos = int.Parse(Console.ReadLine());

kmpercorridos = kmpercorridos * 2;

Console.WriteLine($"{kmpercorridos} minutos de distancia");