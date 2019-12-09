using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;
            //Console.WriteLine($"{szelesseg} és {magassag}");

            Console.SetCursorPosition(szelesseg / 2, magassag / 2);
            Console.Write("*");

            ConsoleKeyInfo cki = Console.ReadKey();

            switch (cki.Key)
            {
                default:
            }


            Console.ReadKey(true);
        }
    }
}
