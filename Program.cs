using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyzatok
{
    internal class Program
    {
        static void pontok()
        {
            int i = 1;
            Console.WriteLine("Hány pontot ért el a tanuló? ");
            i = Convert.ToInt32(Console.ReadLine());
            if ( i >= 0 && i <= 49)
            {
                Console.WriteLine("Elégtelen");
            }
           else if (i >= 49 && i <= 59)
            {
                Console.WriteLine("Elégséges");
            }
            else if (i >= 60 && i <= 79)
            {
                Console.WriteLine("Közepes");
            }
            else if (i >= 80 && i <= 89)
            {
                Console.WriteLine("Jó");
            }
            else if (i >= 90 && i <= 100)
            {
                Console.WriteLine("Jeles");
            }
            else
            {
                Console.Write("Érvénytelen pontszám");
            }
        }
        static void Main(string[] args)
        {
            pontok();
        }
    }
}
