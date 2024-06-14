
using ExemploClasseAnimal;

// Instanciando um objeto do tipo Cachorro
Animal meuCachorro = new Cachorro();

// Instanciando um objeto do tipo Gato
Animal meuGato = new Gato();

// Comportamento polimórfico 
meuCachorro.EmitirSom();

// Comportamento herdado
meuCachorro.Dormir();

meuGato.EmitirSom();

meuGato.Dormir();
