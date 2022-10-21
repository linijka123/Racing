using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ProjektNaZaliczenieNaJIPP
{
     class Czlowiek
     {
        public int licznik;
        private int predkosc = 0; // hermetyzacja
        private KartaZdrowiaCzlowieka karta;
        public KartaZdrowiaCzlowieka Karta
        {
            get
            {
                return karta;
            }
            set
            {
                if(value != null)
                value = karta;
            }
            
        }
        private Serce serce;
        public Serce Serduszko
        {
            get
            {
                return serce;
            }
            set
            {
                if (value != null)
                value = serce;
            }
        }
        private Pluca pluca;
        public Pluca Pluco
        {
            get
            {
                return pluca;
            }
            set
            {
                if(value != null)
                {
                    value = pluca;
                }
            }
        }
        public int Predkosc
        {
            get
            {
                return predkosc;
            }
            set
            {
                if(predkosc>=0)
                {
                     predkosc = value;
                }
            }
        }

        public Czlowiek()
        {

        }
        public Czlowiek(int licznik)
        {
            //kompozycja
            this.licznik = licznik;
            karta = new KartaZdrowiaCzlowieka();
            serce = new Serce();
            pluca = new Pluca();
        }
      
       
     }
   
   
}
