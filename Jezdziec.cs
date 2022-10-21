using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektNaZaliczenieNaJIPP
{
    class Jezdziec
    {
        private int waga , index;
        public Jezdziec(int index , int waga)
        {
            this.index = index;
            this.waga = waga;
        }
        public void WsiadzNaKonia(Kon kon, int szybkosc, int waga , int bicieSeca)
        {  
            kon.Biegnij(szybkosc);
            kon.Waga(waga);
            kon.BicieSerca(bicieSeca);
            Console.WriteLine("Jedziec wybral konia: ");
            Console.WriteLine( kon.RasaKonia());
            
        }
    }
}
