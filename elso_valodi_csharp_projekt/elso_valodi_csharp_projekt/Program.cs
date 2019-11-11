using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso_valodi_csharp_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Feladat
            string kiir = "Hello world";
            Console.WriteLine(kiir);*/

            /*2.Feladat
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Üdvözöllek {nev}!");*/

            /*3.Feladat
            Console.Write("Adj meg egy számot ");
            //int szam = Int32.Parse(Console.ReadLine());
            //double szam = Double.Parse(Console.ReadLine());
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A szám {szam} kétszerese: {2 * szam}");*/

            /*4.Feladat
            Console.Write("Adj meg egy számot ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot ");
            int szamB = Int32.Parse(Console.ReadLine());

            int osszeg = szamA + szamB;
            int kulonbseg = szamA - szamB;
            int szorzat = szamA * szamB;
            double hanyados = (double)szamA / szamB;
            Console.WriteLine($"A két szám: {szamA} és {szamB}: ");
            Console.WriteLine($"összege: {osszeg}");
            Console.WriteLine($"kulonbseg: {kulonbseg}");
            Console.WriteLine($"Szorzata: {szorzat}");
            Console.WriteLine($"Hányadosa: {hanyados}");*/

            /*5.Feladat
            Console.Write("Adj meg egy számot ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA > szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else if (szamB > szamA)
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő");
            }

            if (szamA >= szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }*/

            /*6.Feladat
            Console.Write("Adj meg egy számot ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot ");
            int szamC = Int32.Parse(Console.ReadLine());

            if (szamA <= szamB && szamA <= szamC)
            {
                Console.WriteLine($"A legkisebb szám {szamA}");
            }
            else if (szamB <= szamA && szamB <= szamC)
            {
                Console.WriteLine($"A legkisebb szám {szamB}");
            }
            else if (szamC <= szamA && szamC <= szamB)
            {
                Console.WriteLine($"A legkisebb szám {szamC}");
            }*/

            /*7.Feladat
            Console.Write("Adj meg egy számot ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot ");
            int szamC = Int32.Parse(Console.ReadLine());

            if (szamA < szamB+szamC && szamB < szamA+szamC && szamC < szamA+szamB)
            {
                Console.WriteLine("Szerkeszhető");
            }
            else
            {
                Console.WriteLine("Nem szerkeszthető");
            }*/

            /*8.Feladat
            Console.Write("Adj meg egy számot ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA > 0 && szamB > 0)
            {
                double szamtani = ((double)szamA + szamB) / 2;
                double mertani = Math.Sqrt(szamA * szamB);
                Console.WriteLine($"A két szám: {szamA} és {szamB} számtani közepe {szamtani}");
                Console.WriteLine($"A két szám: {szamA} és {szamB} mértani közepe {mertani}");
            }
            else
            {
                Console.WriteLine("A feladat nem megoldahtó");
            }*/

            /*15.Feladat

            Console.Write("Írj be egy számot ");
            int s = Convert.ToInt32(Console.ReadLine());
            string kiiratas = "";

            for (int i = 1; i <= s; i++)
            {
                kiiratas += i + " ";
            }
            Console.WriteLine(kiiratas);*/

            /*Console.Write("Írj be egy számot ");
            int s = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < s; i++)
            {
                Console.Write(i + " ");
            }*/

            /* Console.Write("Írj be egy számot ");
             int s = Convert.ToInt32(Console.ReadLine());
             int i = 1;*/

            /*while (i < s)
            {
                Console.Write(i++ + " ");
                //i = i + 1;
                //i += 1;
                //i++;
            }*/

            /*do
            {
                Console.Write(i++ + " ");
            } while (i < s);
            */

            //16.Feladat

            Console.Write("Írj be egy számot ");
            int s = Convert.ToInt32(Console.ReadLine());


            Console.ReadKey(true);
        }
    }
}
