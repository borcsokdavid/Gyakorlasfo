using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuggvenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.feladat
            Console.WriteLine("Kérek egy pozitív egész számot");
            int szam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{szam} kettes osztóinak száma: {kettooszto(szam)}");*/

            /*4.Feladat

            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int[] ermek = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] tomb = osztokszama(szam);

            Console.WriteLine($"A(z) {szam} tartalmaz: ");
            Console.WriteLine($"{tomb[0]} 200-as érem");
            Console.WriteLine($"{tomb[1]} 100-as érem");
            Console.WriteLine($"{tomb[2]} 50-es érem");
            Console.WriteLine($"{tomb[3]} 20-as érem");
            Console.WriteLine($"{tomb[4]} 10-es érem");
            Console.WriteLine($"{tomb[5]} 5-ös érem");
            Console.WriteLine($"{tomb[6]} 2-es érem");
            Console.WriteLine($"{tomb[7]} 1-es érem");

            string kiir = $"{szam} =";

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] != 0)
                {
                    kiir += $"{tomb[i]} * {ermek[i]} + ";
                }
            }

            
            Console.WriteLine(kiir);
            //Console.Write('\b');*/


            //6.Feladat

            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int[] tomb = kettesszamrendszer(szam);

            string kiir = $"{szam} = ";



            for (int i = 0; i < tomb.Length; i++)
            {
                kiir += $"{tomb[i]}";
            }
            kiir += ")"




















            Console.ReadKey(true);
        }

        

        static int kettooszto(int szam)
        {
            int osztokszama = 0;

            while (szam % 2 == 0)
            {
                osztokszama++;
                szam /= 2; //szam = szam / 2;
            }
            return osztokszama;
        }

        static int[] osztokszama(int szam)
        {
            int[] ermekszama = new int[8];
            int[] ermek = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };

            for (int i = 0; i < ermek.Length; i++)
            {
                while (szam >= ermek[i])
                {
                    ermekszama[i]++;
                    szam -= ermek[i]; //szam = szam / osztok[i];
                }

            }

            
            return ermekszama;
        }

        static int[] kettesszamrendszer(int szam)
        {
            int meddig = (int)Math.Floor(Math.Log(szam) / Math.Log(2));
            int[] kettesosztokszama = new int[meddig + 1];
            int[] kettesosztok = new int[meddig + 1];

            for (int i = kettesosztok.Length - 1; i>= 0 ; i--)
            {
                kettesosztok[i] = (int)Math.Pow(2, i);
            }

            for (int i = 0; i < kettesosztok.Length; i++)
            {
                while (szam >= kettesosztok[i])
                {
                    kettesosztokszama[i]++;
                    szam -= kettesosztok[i]; //szam = szam / osztok[i];
                }

            }


            return kettesosztokszama;
        }


    }
}
