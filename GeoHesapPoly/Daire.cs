using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoHesapPoly
{
    class Daire:Sekiller
    {
        public Daire(int yaricap)
        {
            Kenar = yaricap;
        }
        public Daire()
        {

        }

        public override void AlanHesapla()
        {
            Console.WriteLine("Dairenin Alanı: "+(Math.PI*Math.Pow(Kenar,2)));
        }
        public override void CevreHesapla()
        {
            Console.WriteLine("Dairenin Çevresi: " + (2*Math.PI * Kenar));
        }

    }
}
