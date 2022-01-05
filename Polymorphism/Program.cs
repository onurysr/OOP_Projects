using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen(10, 8);
            Daire daire = new Daire(5);
            Dikdortgen dikdortgen = new Dikdortgen(8, 6);
            Kup kup = new Kup(5);
            Silinidir silinidir = new Silinidir(5, 8);
            Console.WriteLine("Üçgenin Alanı: "+ucgen.AlanHesapla() +"\n" +
                "Dairenin Alanı: " + daire.AlanHesapla() + "\n" +
                "Dikdörgenin Alanı: " + dikdortgen.AlanHesapla() + "\n" +
                "Kupun Alanı: " + kup.AlanHesapla() + "\n" +
                "Silinidirin Alanı: " + silinidir.AlanHesapla() + "\n");
            Console.ReadLine();
        }

        public class GeoHesap
        {
            public int kenar1;
            public int kenar2;
            
            public virtual int AlanHesapla()
            {
                return kenar1 * kenar2;
            }
        }

        public class Ucgen:GeoHesap
        {
            public int yukseklik;
            public int kenar;
            public Ucgen(int t,int h)
            {
                yukseklik = h;
                kenar = t;

            }
            public override int AlanHesapla()
            {
                return yukseklik * kenar / 2;
            }
        }

        public class Daire : GeoHesap
        {
            public double yaricap;
            public Daire(int r)
            {
                yaricap = r;
            }
            public override int AlanHesapla()
            {
                return Convert.ToInt32(Math.PI * Math.Pow(yaricap, 2));
            }
        }

        public class Dikdortgen : GeoHesap
        {
            public Dikdortgen(int k1,int k2)
            {
                kenar1 = k1;
                kenar2 = k2;
            }
            public override int AlanHesapla()
            {
                return base.AlanHesapla();
            }
        }

        public class Kup : GeoHesap
        {
            public double kenar;
            public Kup(int k)
            {
                kenar = k;
            }
            public override int AlanHesapla()
            {
                return Convert.ToInt32(6 * Math.Pow(kenar, 2));
            }
        }

        public class Silinidir : GeoHesap
        {
            public int yukseklik;
            public int yaricap;
            public Silinidir(int r,int h)
            {
                yukseklik = h;
                yaricap = r;
            }

            public override int AlanHesapla()
            {
                return Convert.ToInt32(Math.Pow(yaricap, 2) * Math.PI * yukseklik);
            }

        }
    }
}
