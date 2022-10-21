using System;
namespace ProjektNaZaliczenieNaJIPP
{
    class KonAjatycki : Kon // dziedziczenie
    {
        private int km;
        public KonAjatycki(int indeks) : base(indeks)
        {
            this.indeks = indeks;
            rasaKonia = "Azjatycki";
        }
    }
}
