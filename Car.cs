using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przygotowanie1
{
    class Car
    {
        private double pojemnoscSilnika;  // Zmienne prywatne są widoczne tylko w obrębie danej klasy.
        private string Marka;
        static int iloscKol;
        public Car(double pojemnoscSilnika,string Marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.Marka = Marka;
        }
        public Car()
        {
            iloscKol = 4;
        }
        public static Car CreateCar()  // Metoda zwracajaca nowy obiekt 
        {
            return new Car();
        }
        public double zwracamPojemnosc()
        {
            return pojemnoscSilnika;
        }
        public string zwracamMarke()
        {
            return Marka;
        }
        public int zwracamIlosc()
        {
            return iloscKol;
        }
        public void ustawiamWartosci(double pojemnoscSilnika,string Marka)
        {
            this.pojemnoscSilnika=pojemnoscSilnika;
            this.Marka = Marka;

        }
        ~Car()
        {
            Console.WriteLine("Czyszcze pamieć");
            Console.ReadKey();
        }
    }
}
