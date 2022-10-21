using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
namespace ProjektNaZaliczenieNaJIPP
{
    class WyscigiZwierzat
    {
        List<Zwierze> konie  = new List<Zwierze>();
        List<Zwierze> konie2 = new List<Zwierze>();

        Random rand = new Random();
        private int x = 0, a , b, c;
        public WyscigiZwierzat(List<Zwierze> konie, List<Zwierze> konie2)
        {
            for( int i=0; i<konie.Count; i++)
            {
                this.konie = konie;
            }
            for (int i = 0; i < konie2.Count; i++)
            {
                this.konie2 = konie2;
            }
        }
       
        public void Scigajsie()
        {
            foreach (Zwierze animal in konie)
            {
                x = rand.Next(1, 150);
                a = rand.Next(70, 150);
                b = rand.Next(1, 5);
                c = rand.Next(1, 5);
                if (animal is Kon)
                {
                    Console.Write($"Biegnie kon {(animal as Kon).RasaKonia()} o numerze:{animal.indeks},");
                    Console.Write(" ");
                    animal.Biegnij(x);
                    animal.Waga(a);
                    animal.BicieSerca(a);

                }
            }
            foreach (Zwierze animal in konie2)
            {
                x = rand.Next(1, 150);
                a = rand.Next(70, 150);
                b = rand.Next(1, 5);
                c = rand.Next(1, 5);

                if (animal is Kon)
                {
                    Console.Write($"Biegnie kon {(animal as Kon).RasaKonia()} o numerze:{animal.indeks},");
                    Console.Write(" ");
                    animal.Biegnij(x); // polimorfizm
                    animal.Waga(a); // polimorfizm 
                    animal.BicieSerca(a); // polimorfizm
                }


            }
            


        } 
    }
}
