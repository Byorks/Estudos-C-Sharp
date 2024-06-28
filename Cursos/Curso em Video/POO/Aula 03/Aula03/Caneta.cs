using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Aula_03
{
    public class Caneta
    {
        public string Modelo;
        public string Cor;
        private double Ponta;
        protected int Carga;
        protected bool Tampada;

        // Método Construtor 
        public Caneta(string cor, int carga)
        {
            Cor = cor;
            Carga = carga;
        }
        public Caneta()
        {
        }
        public void Escrever()
        {
            Console.WriteLine("Escrevendo...");
        }
        public void Rabiscar()
        {   
            if (this.Tampada)
            {
                Console.WriteLine("Não posso rabiscar!" + "/nCanesta está tampada.");
            }
            else
            {
                Console.WriteLine("Estou rabiscando...");
            }
        }

        public void Tampar()
        {
            Tampada = true;
        }

        public void Destampar()
        {
            Tampada = false; 
        }

        // O get properties só funciona se eu estiver com propriedades com get/set
        public static void MostrarEstadoGetProp(Caneta caneta)
        {
            Type type = caneta.GetType();
            PropertyInfo[] propriedades = type.GetProperties();
            foreach (PropertyInfo prop in propriedades)
            {
                Console.WriteLine($"{prop.Name} : {prop.GetValue(caneta)}");
            }
        }

        // Esse método retorna os campos públicos, portanto sem get/set funcionará
        public static void MostrarEstadoGetFields(Caneta caneta)
        {
            Type type = caneta.GetType();
            FieldInfo[] campos = type.GetFields();
            foreach(FieldInfo campo in campos)
            {
                Console.WriteLine($"{campo.Name} : {campo.GetValue(caneta)}");
            }
        }
    }
}
