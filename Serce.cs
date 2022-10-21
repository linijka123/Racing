using System;
using System.Threading;
namespace ProjektNaZaliczenieNaJIPP
{
    class Serce
    {
        private int Akcjeserca;
        private bool krew = true;
        public int AkcjeSerca
        {
            get
            {
                return Akcjeserca;
            }
            set
            {
                if(value > 0)
                {
                    Akcjeserca = value;
                }
            }
        }
        public Serce(int AkcjeSerca)
        {
            this.Akcjeserca = AkcjeSerca;
        }
        public Serce()
        {
            Akcjeserca = 1;
        }
        public void NiechBijeSerce()
        {

            if (krew == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                char o = 'o';
                Console.WriteLine("  " + o + o + o + "   " + o + o + o);
                Console.WriteLine(" " + o + "   " + o + " " + o + "   " + o);
                Console.WriteLine(o + "     " + o + "     " + o);
                Console.WriteLine(o + "     " + " " + "     " + o);
                Console.WriteLine(o + "     " + " " + "     " + o);
                Console.WriteLine(" " + o + "    " + "     " + o);
                Console.WriteLine("  " + o + "   " + "    " + o);
                Console.WriteLine("   " + o + "  " + "   " + o);
                Console.WriteLine("    " + o + "  " + " " + o);
                Console.WriteLine("     " + o + " " + o);
                Console.WriteLine("      " + o);
                Console.ResetColor();
            }
            else if (krew == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                char o = 'o';
                Console.WriteLine("  " + o + o + o + "   " + o + o + o);
                Console.WriteLine(" " + o + "   " + o + " " + o + "   " + o);
                Console.WriteLine(o + "     " + o + "     " + o);
                Console.WriteLine(o + "     " + " " + "     " + o);
                Console.WriteLine(o + "     " + " " + "     " + o);
                Console.WriteLine(" " + o + "    " + "     " + o);
                Console.WriteLine("  " + o + "   " + "    " + o);
                Console.WriteLine("   " + o + "  " + "   " + o);
                Console.WriteLine("    " + o + "  " + " " + o);
                Console.WriteLine("     " + o + " " + o);
                Console.WriteLine("      " + o);
                Console.ResetColor();
            }




        }
    }
}
