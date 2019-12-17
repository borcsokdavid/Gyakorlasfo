using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozathetfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Alap összeg: ");
            double osszeg = Double.Parse(Console.ReadLine());
            double alaposszeg = osszeg;
            double evesosszeg = osszeg;
            Console.Write("Kamatláb: ");
            double kamat =Double.Parse(Console.ReadLine());
            Console.Write("Futamidő: ");
            int futamido = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.SetCursorPosition(13, 4);
            Console.Write("Évenkénti összeg");
            Console.SetCursorPosition(32, 4);
            Console.Write("Összhozam");
            Console.SetCursorPosition(45, 4);
            Console.Write("Éves hozam");

            for (int i = 0; i < futamido; i++)
            {

                osszeg =(kamat / 100 + 1) * osszeg;
                Console.SetCursorPosition(0, 5 + i);
                Console.Write($"{i + 1}. év végén: {osszeg:F0}Ft \t ");
                Console.SetCursorPosition(32, 5 + i);
                Console.Write($"{osszeg - alaposszeg: F0}Ft");
                Console.SetCursorPosition(45, 5 + i);
                Console.Write($"{osszeg - alaposszeg: F0}Ft");
                evesosszeg = osszeg;
            }






            Console.ReadKey(true);

        }
    }
}
