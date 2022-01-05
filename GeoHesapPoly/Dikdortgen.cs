using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoHesapPoly
{
    class Dikdortgen:Sekiller
    {
        private double _kenar2;
        public double Kenar2 {
            get { return _kenar2; }
            set { _kenar2 = value; }
        }

        public Dikdortgen(double kisaKenar,double uzunKenar )
        {
            Kenar = kisaKenar;
            Kenar2 = uzunKenar;
        }
        public Dikdortgen()
        {

        }

        public override void AlanHesapla()
        {
            Console.WriteLine("DD Alanı: " + (Kenar*Kenar2));
        }

        public override void CevreHesapla()
        {
            Console.WriteLine("DD Çevresi: " + ((Kenar+Kenar2)*2));
        }
    }
}
