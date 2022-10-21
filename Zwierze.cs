using System;
namespace ProjektNaZaliczenieNaJIPP
{
    abstract class Zwierze
    {
        public int indeks = 0;
        public Zwierze(int indeks)
        {
            this.indeks = indeks;
        }
        public abstract void BicieSerca(int x);
        public abstract void Waga(int x);
        public abstract void Biegnij(int x);
    }
}
