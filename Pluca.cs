using System;
namespace ProjektNaZaliczenieNaJIPP
{
    class Pluca
    {
        private int szerokoscPluc;
        public int PlucaOddychaj
        {
            get
            {
                return szerokoscPluc;
            }
            set
            {
                if(value>0)
                {
                     szerokoscPluc = value;
                }
            }
        }

        public Pluca()
        {
        }
        public Pluca(int SzerokoscPluc)
        {
            this.szerokoscPluc = SzerokoscPluc;
        }

    }
}
