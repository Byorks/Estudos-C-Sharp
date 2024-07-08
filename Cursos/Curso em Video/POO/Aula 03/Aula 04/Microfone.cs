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
        private string _padraoPolar = "Não definido";
        public string PadraoPolar
        {
            get => _padraoPolar;
            set
            {
                if (value.ToLower() == "omnidirecional" || value.ToLower() == "Cardioide")
                {
                    _padraoPolar= value;
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
            Console.WriteLine("Gravando Som");
        }

        public void MostrarDetalhes(Microfone m)
        {
            Console.WriteLine($"Padrão Polar: {m.PadraoPolar}");
            Console.WriteLine($"Modelo: {m.Modelo}");
        }
    }
}
