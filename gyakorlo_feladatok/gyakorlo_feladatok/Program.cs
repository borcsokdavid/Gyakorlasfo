using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlo_feladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Feladat
            Console.Write("Kérem a tömb elemszámát");
            int elemszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[elemszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                tomb[i] = Int32.Parse(Console.ReadLine());


            }

            int maxkulonbseg = Int32.MinValue;

            for (int i = 0; i < tomb.Length - 1; i++)
            {
                int kulonbseg = Math.Abs(tomb[i] - tomb[i + 1]);
                

                Console.WriteLine(kulonbseg);
                if (maxkulonbseg <= kulonbseg)
                {
                    maxkulonbseg = kulonbseg;
                }
            }
            Console.WriteLine($"A maximális különbség: {maxkulonbseg}");*/
            //2.Feladat
            Console.Write("Kérem a tömb elemszámát");
            int elemszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[elemszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                tomb[i] = Int32.Parse(Console.ReadLine());
            }

            int elso = 0;
            int masodik = 0;
            int minkulonbség = Int32.MaxValue;

            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = i; j < tomb.Length; j++)
                {

                }
            }




            Console.ReadKey(true);
        }
    }
}

