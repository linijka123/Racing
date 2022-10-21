namespace ProjektNaZaliczenieNaJIPP
{
    class KartaZdrowiaCzlowieka
    {
        private int glukoza, morfologia, zelazo, magnes; // hermetyzacjca
        public KartaZdrowiaCzlowieka(int glukoza, int morfologia, int zelazo, int magnes)
        {
            this.glukoza = glukoza;
            this.morfologia = morfologia;
            this.zelazo = zelazo;
            this.magnes = magnes;
        }
        public KartaZdrowiaCzlowieka()
        {
            Magnez = 1;
        }
        public int Glukoza
        {
            get
            {
                return glukoza;
            }
            set
            {
                
                 glukoza = value;
            }
        }
        public int Morfologia
        {
            get
            {
                return morfologia;
            }
            set
            {
                
                morfologia = value;
            }
        }
        public int Zelazo
        {
            get
            {
                return zelazo;
            }
            set
            {
                
                zelazo = value;
            }
        }
        public int Magnez
        {
            get
            {
                return magnes;
            }
            set
            {
                 magnes = value;
            }
        }
    }
}
