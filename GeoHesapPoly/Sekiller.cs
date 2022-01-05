using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoHesapPoly
{
     class Sekiller
    {
        private double _kenar;

        public double Kenar {
            get { return _kenar; }
            set { _kenar = value; }
        }

        public virtual void AlanHesapla()
        {
            //....
            Console.WriteLine("Bu Base Class'taki Alan Hesapla Metodur.");
        }

        public virtual void CevreHesapla()
        {
            Console.WriteLine("Bu Base Class'taki Çevre Hesapla Metodur.");
        }

    }
}
