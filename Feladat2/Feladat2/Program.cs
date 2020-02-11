using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feladat2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[53];

            
            int szamok = 0;
            int nulla = 0;


            using (StreamReader sr = new StreamReader("szamok.txt", Encoding.UTF8))
            {
                for (int i = 0; i < 53; i++)
                {
                    tomb[i] = Int32.Parse(sr.ReadLine());
                    if (tomb[i] >=15)
                    {
                        szamok++;
                    }
                    if (tomb[i] == 0)
                    {
                        nulla++;
                    }
                }
                Array.Sort(tomb);
            }

            Console.WriteLine($" 1.Feladat: A számok amik elérik a 15-öt: {szamok}");
            
            Console.WriteLine($" 2.Feladat: Számok növekvő sorrendbe:");

            foreach (int i in tomb)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\n 3.Feladat: Hány nulla van a számok között: {nulla}");
            Console.WriteLine($"\n 4.Feladat: A legnagyobb szám a tömbben: {tomb.Max()}");
            Console.ReadKey(true);
        }
    }
}
