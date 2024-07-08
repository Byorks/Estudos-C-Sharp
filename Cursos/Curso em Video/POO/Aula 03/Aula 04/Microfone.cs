using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04
{
    public class Microfone
    {   
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public bool Ligado { get; set; }    
        public string Sensibilidade { get; set; }
        public string PadraoPolar
        {
            get => PadraoPolar;
            set
            {
                if (value.ToLower() == "omnidirecional" || value.ToLower() == "Cardioide")
                {
                    PadraoPolar = value;
                }
            }
        }

        public Microfone()
        {
            Ligado = false;
        }

        public Microfone(string fabricante, string modelo, string cor, bool ligado, string sensibilidade, string padraoPolar)
        {
            Fabricante = fabricante;
            Modelo = modelo;
            Cor = cor;
            Ligado = ligado;
            Sensibilidade = sensibilidade;
            PadraoPolar = padraoPolar;
        }

        public void MicLigado()
        {
            Ligado = true;
            Console.WriteLine("O microfone está ligado!");
        }
        public void GravarSom()
        {

        }
    }
}
