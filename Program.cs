using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przygotowanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            // Car1.Pole nie mozliwe poniewaz pola w klasach sa prywatne
            Car Car2 = new Car(13.43, "Opel");
            Car Car3 = new Car(15, "Nissan");
            // Podczas nadania konstruktorom modyfikatorow Private zadzieje sie to samo co wyzej. Nie beda one widoczne.
            Car Car4 = Car.CreateCar();  // Tworzenie obiektu za pomoca metody, a nie konstruktora.
            Console.WriteLine("Car1 : {0}, {1},{2}", Car1.zwracamMarke(), Car1.zwracamPojemnosc(),Car1.zwracamIlosc());
            Console.WriteLine("Car2 : {0}, {1},{2}", Car2.zwracamMarke(), Car2.zwracamPojemnosc(), Car2.zwracamIlosc());
            Console.WriteLine("Car3 : {0}, {1},{2}", Car3.zwracamMarke(), Car3.zwracamPojemnosc(), Car3.zwracamIlosc());
            Console.WriteLine("Car4 : {0}, {1},{2}", Car4.zwracamMarke(), Car4.zwracamPojemnosc(), Car4.zwracamIlosc());


            Car4.ustawiamWartosci(14, "Toyota");
            Console.WriteLine("Car4 : {0}, {1},{2}", Car4.zwracamMarke(), Car4.zwracamPojemnosc(), Car4.zwracamIlosc());  // Ustawienie wartosci za pomoca metody, a nie konstruktora

            
            Console.ReadKey();

        }
    }
}
