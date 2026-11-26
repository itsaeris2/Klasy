using System;

namespace Klasy_pocz
{
    public class Auto
    {
        public double Cena { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        private int Przebieg { get; set; } = 0;
        public int Rocznik { get; set; }

        public Auto(double cena, string model, string marka, int rocznik)
        {
            Cena = cena;
            Model = model;
            Marka = marka;
            Rocznik = rocznik;
        }

        public void Prowadz()
        {
            Przebieg += 100;
            Console.WriteLine("Przebieg: " + Przebieg + " km");
        }

        public void Zatrzymaj()
        {
            Console.WriteLine("Zatrzymano samochód");
        }

        public void Opisz()
        {
            Console.WriteLine("Marka: " + Marka);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Cena: " + Cena);
            Console.WriteLine("Rocznik: " + Rocznik);
            Console.WriteLine("Przebieg: " + Przebieg);
        }

        public void Promocja()
        {
            Cena = Cena * 0.9;
            Console.WriteLine("Nowa cena: " + Cena);
        }
    }
}
