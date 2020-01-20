using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabitelso
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("Kérem az alapot: ");
             int alap = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Kérem a magasságot: ");
             int magassag = Convert.ToInt32(Console.ReadLine());
             Haroszog haromSzog = new Haroszog(alap, magassag);
             Console.WriteLine($"A háromszög területe: )}");
             Console.WriteLine($"A háromszög területe: );*/


            /*Console.WriteLine("Kérem a számot: ");
            int elsoSzam = Convert.ToInt32(Console.ReadLine());*/



            /*Console.Write("Kérem a logikai értéket: ");
            //bool elsoSzam = Convert.ToBoolean(Console.ReadLine());
            int elsoSzam = Convert.ToInt32(Console.ReadLine());
            elso elso = new elso(elsoSzam);
            //Console.WriteLine($"A logiaki érték negáltja: {Megfordit(elsoSzam)}");*/


            /*Console.WriteLine("Kérem a számot: ");
            int elsoSzam = Convert.ToInt32(Console.ReadLine());
            elso elso = new elso(elsoSzam);
            elso masodik = new elso(5);

            Console.WriteLine($"A szám osztahó-e öttel: {OttelOszthato(elsoSzam)}");
            Console.WriteLine($"A szám oszható-e öttel: {elso.OttelOszthato()}");
            Console.WriteLine($"A szám oszható-e öttel: {elso.OttelOszthato(masodik)}");*/


            Console.Write("Kérem az első sztringet: ");
            string elsoSzoveg = Console.ReadLine();
            Sztringek elso = new Sztringek(elsoSzoveg);
            Console.Write("Kérem a második sztringet: ");
            string masodikSzoveg = Console.ReadLine();
            Sztringek masodik = new Sztringek(masodikSzoveg);

            /*Console.WriteLine($"A két sztring egyenlő hosszú: {elso.EgyenloHosszuak()}");
            Console.WriteLine($"A két sztring fordítva összefűzve: {egyutt.Osszefuz()}");*/
            Console.WriteLine($"Az első sztrinigben van-e space: {masodik.VanESpaceMasodik()}");


            Console.ReadKey(true);
        }


        static int Kovetkezo(int a)
        {
            return a + 1;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static double HaromszogTerulet(double alap, double magassag)
        {
            return (alap * magassag) / 2;
        }

        static int Maradek(int a, int b)
        {
            return a % b;
        }

        static bool Elojel(int a)
        {
            if (a <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static bool Megfordit(bool logikaiErtek)
        {
            return !logikaiErtek;
        }

        static bool OttelOszthato (int a)
        {
            if (a % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        
        
    }
}
