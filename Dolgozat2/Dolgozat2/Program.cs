using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy szót: ");
            string str = Console.ReadLine();
            Console.Write("Hányszor ismétlődjön: ");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"A megoldás: {Repeatt.Re)}");
           
            Console.ReadKey(true);
        }
    }
      
}
