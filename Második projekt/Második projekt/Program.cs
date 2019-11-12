using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Második_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("1-től 100-ig azok a számok melyek valódi osztóinak összege osztható 7-tel.");
            for (int i = 1; i < 101; i++)
            {
                if (osseghettel(i))
                {
                    Console.WriteLine($"{i} valódi osztóinak összege osztható 7-tel.");
                }
                        



            }*/

            Console.WriteLine("2-től 100-ig prímszámok ");

            for (int i = 2; i < 101; i++)
            {
                if (primsezame(i))
                {
                    Console.WriteLine(i);
                }


            }



            Console.ReadKey(true);


        }


        static bool osseghettel(int szam)
        {
            int osszeg = 0;
            bool hettel = true;

            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    osszeg += i;
                }
            }

            if (osszeg % 7 != 0)
            {
                hettel = false;
            }

            return hettel;

        }

        static bool primsezame(int szam)
        {
            bool prime = true;
            int hatar = (int)Math.Floor(Math.Sqrt(szam)) + 1;

            for (int i = 2; i < hatar; i++)
            {
                if (szam % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }


    }
}
