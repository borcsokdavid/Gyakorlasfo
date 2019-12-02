using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szovegkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*50.Feladat
            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();

            for (int i = 0; i < szo.Length; i++)
            {
                Console.Write(szo[i] + " ");
            }
            Console.Write('\b');*/


            /*51.Feladat

            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();
            Console.Write("Kérem a a tabu karaktert: ");
            char tabu = Char.Parse(Console.ReadLine());

            for (int i = 0; i < szo.Length; i++)
            {
                if (szo[i] != tabu)
                {
                    Console.Write(szo[i]);
                }
            }*/

            /*52.Feladat

            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();

            for (int i = 0; i < szo.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(szo[i]);
                }
            }*/

            /*Plusz feladat: Adott indexű elem kiííratása

            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();
            Console.Write("Kérem az indexet");
            int index = Int32.Parse(Console.ReadLine());


            if (index < szo.Length)
            {
                Console.WriteLine($"A keresett karakter: {szo[index]}");
            }
            else
            {
                Console.WriteLine($"Ilyen indexű karakter nincs. (0 - {szo.Length - 1})");
            }*/

            /*53.Feladat

            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();

            int i = 0;

            while (i < szo.Length)
            {
                Console.WriteLine($"{szo[i]} - {(int)szo[i]}");
                i++;
            }*/


            /*54.Feladat

            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();

            for (int i = szo.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(szo[i]);
            }*/

            /*55.Feladat

            Console.Write("Kérek egy mondatot: ");
            string mondat = Console.ReadLine();

            for (int i = 0; i < mondat.Length; i++)
            {
                if ((int)mondat[i] != 32)
                {
                    Console.Write(mondat[i]);
                }
                else
                {
                    Console.WriteLine();
                }
            }*/

            /*55.Feladat második megoldás
            Console.Write("Kérek egy mondatot: ");
            string mondat = Console.ReadLine();

            string[] tomb = mondat.Split('e');
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }*/

            /*56.Feladat

            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();
            string forditottszo = "";

            for (int i = szo.Length - 1; i >= 0; i--)
            {
                forditottszo += szo[i];
                
            }
                 Console.WriteLine(forditottszo.ToUpper());*/

            /*57.Feladat

            Console.Write("Kérek egy mondatot: ");
            string mondat = Console.ReadLine();


            string[] tomb = mondat.Split(' ');
            for (int i = 0; i < tomb.Length; i++)
            {
                string elsobetu = tomb[i].Substring(0, 1).ToUpper();
                string maradek = tomb[i].Substring(1);
                Console.WriteLine(elsobetu + maradek);
            }
            */

            //Plusz feladat
            Console.Write("Kérek egy mondatot: ");
            string szo = Console.ReadLine();
            string kiir = "";


            for (int i = 0; i < szo.Length; i++)
            {
                if (i % 2 == 0)
                {
                    char ch = (char)((int)szo[i] - 32);
                    kiir += ch;
                }
                else
                {
                    kiir += szo[i];
                }
            }
            Console.WriteLine(kiir);




            









            Console.ReadKey(true);



        }
    }
}
