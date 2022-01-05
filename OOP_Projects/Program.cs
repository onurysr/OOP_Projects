using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            birSinif a = new birSinif();
            birSinif b = new birSinif();
            a.j = 11;
            Console.WriteLine(a.j);
            Console.WriteLine(b.j);
            birSinif.i = 30;
            Console.WriteLine(birSinif.i);
            Console.ReadKey();
        }

        class birSinif
        {
            public static int i = 10;
            public int j = 10;
        }
    }
}
