using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
namespace ProjektNaZaliczenieNaJIPP
{
    class Kon : Zwierze // dziedziczenie po klasie abstrakcyjnej
    {
        public int km = 0;
        protected string rasaKonia;
        public Kon(int indeks) : base(indeks)
        {
            this.indeks = indeks; // mozna wyrzucic , nadpisuje ta sama wartosc
            rasaKonia = "Bez rasowy";
        }
        public override void BicieSerca(int a) // przeciazanie metod 
        {
            Console.WriteLine("Bicie serca wynosi:"+ a);
        }
        public override void Biegnij(int x)
        {
            Console.Write("Maksymalna predkosc konia wynosi: " + x+ "km/h,");
        }
        public override void Waga(int a)
        {
            Console.Write("Waga konia wynosi:"+a);
        }
        public virtual string RasaKonia()
        {
            return rasaKonia;
        }

    }
   
}
