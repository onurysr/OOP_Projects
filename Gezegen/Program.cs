using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gezegen
{
    class Gezegen
    {
        public int yariCap;
        public double yerCekim;
        private string ad;
        private static int sayac;

        public Gezegen(int r,double g,string n)
        {
            yariCap = r;
            yerCekim = g;
            ad = n;
            sayac++;
        }

        public string AdYaz()
        {
            return ad;
        }

        public static int GezegenSay()
        {
            return sayac;
        }
        static void Main(string[] args)
        {
            Gezegen earth = new Gezegen(6378, 9.81, "Earth");
            Gezegen saturn = new Gezegen(60268, 8.96, "Saturn");
            Console.WriteLine("Gezgen Sayisi: " + Gezegen.GezegenSay());
            Console.ReadLine();
        }
    }
}
