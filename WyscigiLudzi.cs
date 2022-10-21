using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace ProjektNaZaliczenieNaJIPP
{
    class WyscigiLudzi
    {
        List <Czlowiek> czlowiek;
        int suma = 0 , roznica = 0 , srednia = 0 , wynik = 0, indeks3=0;
        Random rnd = new Random();
        public WyscigiLudzi(List<Czlowiek> ListaZakwalikowanych)
        {
            for (int i = 0; i < ListaZakwalikowanych.Count; i++)
            {
                this.czlowiek = ListaZakwalikowanych;
            }
        }

        public void ZacznijWyscig()
        {
            foreach (Czlowiek ludzie in czlowiek)
            {
                ludzie.Predkosc = rnd.Next(1,100);
                ludzie.Serduszko.AkcjeSerca = rnd.Next(60, 180);
                ludzie.Pluco.PlucaOddychaj = rnd.Next(6000, 8000);

                Console.WriteLine($"Predkosc zawodnika {ludzie.licznik} to "+ludzie.Predkosc+"km/h"+"Akcje serca w trakcie biegu" +
                $"utrzymywaly sie w {ludzie.Serduszko.AkcjeSerca}, pojemnosc pluc {ludzie.Pluco.PlucaOddychaj} ml" );
                suma += ludzie.Predkosc;
            }
    
            int najmniejszaPredkosc = czlowiek[0].Predkosc;
            int najwiekszaPredkosc = czlowiek[0].Predkosc;

            int indeks = 0 , indeks2 = 0;
            foreach (Czlowiek ludzie in czlowiek)
            {
                if(ludzie.Predkosc <= najmniejszaPredkosc)
                {
                    najmniejszaPredkosc = ludzie.Predkosc;
                    indeks = ludzie.licznik;
                }
                if(ludzie.Predkosc >= najwiekszaPredkosc)
                {
                    najwiekszaPredkosc = ludzie.Predkosc;
                    indeks2 = ludzie.licznik;

                }
            }
            srednia = (suma / czlowiek.Count);
            double wariancja = 0;
            foreach (Czlowiek ludzie in czlowiek)
            {
                double odchylenie = ludzie.Predkosc - srednia;
                wariancja += odchylenie * odchylenie;
            }
            Console.WriteLine($"Najmniejsza predkosc to {najmniejszaPredkosc} km/h uzyskal go zawodnik {indeks}");
            Console.WriteLine($"Najwieksza predkosc to {najwiekszaPredkosc} km/h uzyskal go zawodnik {indeks2}");
            Console.WriteLine($"Srednia biegow zawodnikow wynosi {suma / czlowiek.Count} km/h");
            Console.WriteLine($"Wariancja zbioru {wariancja / czlowiek.Count}");

            foreach (Czlowiek ludzie in czlowiek)
            {
                roznica = srednia - ludzie.Predkosc;
                if (roznica < 0)
                {
                    roznica = -roznica;
                }
                if (roznica < najmniejszaPredkosc)
                {
                    najmniejszaPredkosc = roznica;
                    wynik = ludzie.Predkosc;
                    indeks3 = ludzie.licznik;

                }    
            }
            Console.WriteLine($"Wartosc najblizsza sredniej {wynik}, pierwszy uzyskal zawodnik {indeks3}");

            //Console.WriteLine($"Badamy pulsometrem zadownika {zawodnik.licznik}");
            //zawodnik.uzyjPulsometra(10, pulsometr);
        }


    }
}
