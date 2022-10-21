using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
namespace ProjektNaZaliczenieNaJIPP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int licznik = 0;
            Czlowiek czlowiek = new Czlowiek(licznik);

            List<Czlowiek> druzyna;

            druzyna = new List<Czlowiek>();

            // druzyna.Add(czlowiek);

            int ileZawodnikow = int.Parse(Console.ReadLine());
            for (int i = 0; i < ileZawodnikow; i++)
            {
                Czlowiek zawodnik = new Czlowiek(licznik);
                licznik++;
                druzyna.Add(zawodnik);
            }
            Random rnd = new Random();
            int poczatek = 1;
            int koniec = 11;
            bool spr = false;
            List<Czlowiek> zakwalifikowani = new List<Czlowiek>();

            foreach (Czlowiek zawodnik in druzyna)
            {
                Console.WriteLine($"Badamy karte zdrowia zadownika {zawodnik.licznik} ");
                zawodnik.Karta.Magnez = rnd.Next(poczatek, koniec); // asocjacja , jest polem innej klasy // zwiazek obiektu przez pewien czas // klasa czlowiek uzywa referencji do typu adres w kontekscie jej atrybutu
                zawodnik.Karta.Morfologia = rnd.Next(poczatek, koniec);
                zawodnik.Karta.Zelazo = rnd.Next(poczatek, koniec);
                zawodnik.Karta.Glukoza = rnd.Next(poczatek, koniec);

                if (zawodnik.Karta.Magnez > 0 && zawodnik.Karta.Morfologia > 0
                  && zawodnik.Karta.Zelazo > 0 && zawodnik.Karta.Glukoza > 0)
                {
                    Console.WriteLine($"Zawodnik {zawodnik.licznik} zostal zakawalifikowany");
                    //Thread.Sleep(5000);
                    zakwalifikowani.Add(zawodnik);
                }
            }
            WyscigiLudzi wyscigiLudzi = new WyscigiLudzi(zakwalifikowani);
            wyscigiLudzi.ZacznijWyscig();

            const int ilu = 9;
            int licznik3 = 0, licznik2 = 0;

            List<Zwierze> konie = new List<Zwierze>();
            List<Zwierze> konie2 = new List<Zwierze>();

            for (int i = 0; i < ilu; i++)
            {
                Zwierze zwierze = new KodArabski(licznik3); // kolekcja obiektow
                licznik3++;
                konie.Add(zwierze);
            }
            for (int i = 0; i < ilu; i++)
            {
                Zwierze zwierze2 = new KonAjatycki(licznik2); // kolekcja obiektow
                licznik2++;
                konie2.Add(zwierze2);
            }
            WyscigiZwierzat wyscigi = new WyscigiZwierzat(konie, konie2);
            wyscigi.Scigajsie();
           

            Console.WriteLine("Dane z jezdzcami: ");
            Random generuj = new Random();
            int x = generuj.Next(1, 100);
            int y = generuj.Next(1, 100);
            int z = generuj.Next(1, 100);

            int waga1=70, waga2=95, waga3=145;

            int obstaw1 = generuj.Next(1, 500);
            int obstaw2 = generuj.Next(1, 500);
            int obstaw3 = generuj.Next(1, 500);


            KonAjatycki zwierzatko1 = new KonAjatycki(1);
            KonAjatycki zwierzatko2 = new KonAjatycki(2);
            KonAjatycki zwierzatko3 = new KonAjatycki(3);

            Jezdziec jezdziec = new Jezdziec(1, waga1);
            Jezdziec jezdziec2 = new Jezdziec(2, waga2);
            Jezdziec jezdziec3 = new Jezdziec(3, waga3);

           
            jezdziec.WsiadzNaKonia(zwierzatko1, x, waga1+120, 90);
            jezdziec.WsiadzNaKonia(zwierzatko2, y, waga2+120, 90);
            jezdziec.WsiadzNaKonia(zwierzatko3, z, waga3+120, 90);

            Console.ReadKey();

        }
    }
}
