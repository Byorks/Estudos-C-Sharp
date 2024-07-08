using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04
{
    public class Caneta
    {
        public string Modelo { get; set; }
        private float Ponta { get; set; }
        private bool Tampada { get; set; }
        private string Cor {  get; set; }

        // Método Construtor - Assim que eu criar o objeto, esses comandos serão automáticamente executados
        public Caneta()
        {
            Cor = "Azul";
            Tampar();
        }
        public Caneta(string m, string c, float p)
        {
            Modelo = m;
            Cor = c;
            Ponta = p;
            Tampar();
        }
        public void GetModelo() 
        {
            Console.WriteLine(Modelo); 
        }

        public void SetModelo(string m)
        {
            Modelo = m;
        }

        public void GetPonta()
        {
            Console.WriteLine(Ponta);
        }

        public void SetPonta(float p) 
        {
            Ponta = p;
        }

        public void Tampar()
        {
            Console.WriteLine($"Caneta está tampada");
            Tampada = true;
        }
        public static void MostrarPropriedades(Caneta caneta)
        {
            Type type = caneta.GetType();
            PropertyInfo[] propInfo = type.GetProperties();
            foreach (PropertyInfo prop in propInfo)
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(caneta)} "); // Com o modelo privado, não consigo printa-lo
            }

        }

    }
}
