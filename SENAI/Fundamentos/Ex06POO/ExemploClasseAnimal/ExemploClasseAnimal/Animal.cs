using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseAnimal
{
    public abstract class Animal
    {
        //Método Abstrato (sem implementação)
        public abstract void EmitirSom();

        //Método concreto (com implementação)
        public void Dormir()
        {
            Console.WriteLine("O animal está dormindo");
        }
    }
}
