using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Console.Write("Hány szavas legyen a mondat? ");
            int hossz = int.Parse(Console.ReadLine());
            string[] mondat = new string[hossz];
            
            for (int i = 0; i < hossz; i++)
            {
                Console.Clear();
                int x = r.Next(1, 12);
                string szo = "";
                while (szo.Length != x)
                {
                    Console.Write($"Az {i + 1}. legyen {x} betű: ");
                    szo = Console.ReadLine();
                }
                mondat[i] = Convert.ToString(szo);
            }
            Console.WriteLine("\n A mondat:");
            for (int i = 0; i < mondat.Length; i++)
            {
                if (i == mondat.Length - 1)
                {
                    Console.Write(mondat[i] + " ");
                }
                else
                {
                    Console.Write(mondat[i] + " ");
                }
            }
           Console.ReadKey(true);

        }
    }
}
