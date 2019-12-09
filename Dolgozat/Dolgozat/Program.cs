using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mivel számoljak? (kör, négyzet, téglalap, derékszögű háromszög)");
            string bemenet = Console.ReadLine();
            if (bemenet == "kör")
            {
                Console.Clear();
                Console.Write("Adj meg egy sugarat:");
                double sugar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A sugár: " + sugar);
                double kerulet = 2 * sugar * Math.PI;
                Console.WriteLine("A kerület: " + kerulet);
                double terulet = sugar * sugar * Math.PI;
                Console.WriteLine("A terület: " + terulet);

            }
            else if (bemenet == "négyzet")
            {
                Console.Clear();
                Console.Write("Adja meg a négyzet oldalát: ");
                int oldal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A kerület: " +(4 * oldal));
                Console.WriteLine("A terület: " + (oldal * oldal));
            }
            else if (bemenet == "téglalap")
            {
                Console.Clear();
                Console.Write("Kérem a téglalap első oldal hosszát: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kérem a téglalap második oldal hosszát: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A kerület: " + ((a + b) * 2));
                Console.WriteLine("A terület: " + (a * b));
            }
            else if (bemenet == "derékszögű háromszög")
            {
                Console.Clear();
                Console.Write("Kérem az első befogót: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kérem a második befogót: ");
                int b = Convert.ToInt32(Console.ReadLine());
                double c = Math.Sqrt(Math.Pow(a, 2) + b * b);
                double kerulet = a + b + c;
                int terulet = (a * b) / 2;
                Console.WriteLine("A kerület: " + (kerulet));
                Console.WriteLine("A terület: " + (terulet));

            }









            Console.ReadKey(true);
        }
       
    }
    
}
