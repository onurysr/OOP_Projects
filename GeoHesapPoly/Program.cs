using System;

namespace GeoHesapPoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Sekiller hesapla = new Sekiller();

            Kare kare = new Kare(8);
            //kare.AlanHesapla();
            //kare.CevreHesapla();

            Dikdortgen dikdortgen = new Dikdortgen(5,10);
            //dikdortgen.AlanHesapla();
            //dikdortgen.CevreHesapla();

            Daire daire = new Daire(7);
            //daire.AlanHesapla();
            //daire.CevreHesapla();

            Hesapla(kare);
            Hesapla(dikdortgen);
            Hesapla(daire);

            Console.ReadLine();


        }

        private static void Hesapla(Sekiller sekil)
        {
            sekil.AlanHesapla();
            sekil.CevreHesapla();
        }
    }
}
