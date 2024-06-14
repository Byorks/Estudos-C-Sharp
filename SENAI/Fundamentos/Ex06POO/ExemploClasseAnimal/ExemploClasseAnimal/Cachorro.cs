using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseAnimal
{
    public class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Cachorro: Au au");
        }
    }
}
