using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoHesapPoly
{
    public class Kare:Sekiller
    {
        public Kare(double kenar)
        {
            //this.Kenar = kenar; aynısı
            Kenar = kenar;
        }

        public Kare()
        {

        }

        public override void AlanHesapla()
        {
            Console.WriteLine("Karenin Alanı: "+ (Kenar*Kenar));
        }
        public override void CevreHesapla()
        {
            Console.WriteLine("Karenin Çevresi: " + (4 * Kenar));
        }
    }
}
