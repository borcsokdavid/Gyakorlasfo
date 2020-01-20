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
            Console.WriteLine($"A háromszög területe: {HaromszogTerulet(alap, magassag)}");
            Console.WriteLine($"A háromszög területe: {Haroszog.TeruletSzamol()}");*/




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

        
        
    }
}
