using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
namespace ProjektNaZaliczenieNaJIPP
{
   public class Pulsometr
    {
        private int czestotliwosc;
        
        public  void WyswietlPuls(int p)
        {
            string linia = "___ ";
            int licz = 0;
            bool czas = true;
            czestotliwosc = p;
            Console.WriteLine("Liczba wyczuwalnych uderzen" +
            " w ciagu minuty wynosi: " + czestotliwosc);
            if(czestotliwosc > 0)
            {
                while (czas)
                {
                    Console.Write("___ " + linia);
                   //Thread.Sleep(czestotliwosc * 100);
                    licz++;
                    if (licz == 10)
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nie podlaczyles pulsometra!");
                Console.Write("___ " + linia);

            }
        }
    }
}
