using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles
{
    enum Napok { Hétfő = 12, Kedd, Szerda = 123, Csütörtök, Péntek, Szombat, Vasárnap }
    class Program
    {
        enum Hónap { Január, Február, Március, Április, Május }
        static void Main(string[] args)
        {
            /*int szam = 2;
            bool kiertekel = true;

            while (kiertekel && szam >= 0)
            {
                Console.Write("Kérek egy pozitív egész számot: ");
                kiertekel = !Int32.TryParse(Console.ReadLine(), out szam);
                if (szam <= 0)
                {
                    kiertekel = true;
                    szam = 1;
                }
            }

            Console.WriteLine($"A bekért szám: {szam}");*/

            /*int szam1 = 1;
            int szam2 = 2;
            bool kiertekel = true;
            bool kiertekel2 = true;



            while ((kiertekel || kiertekel2) && (szam1 + szam2) <= 10)
            {
                Console.Write("Kérem az első egész számot: ");
                kiertekel = !Int32.TryParse(Console.ReadLine(), out szam1);
                Console.Write("Kérem a második számot: ");
                kiertekel2 = !Int32.TryParse(Console.ReadLine(), out szam2);
                if ((szam1 + szam2 >= 10))
                {
                    kiertekel = true;
                    kiertekel2 = true;
                    szam1 = 1;
                    szam2 = 1;
                }
            }
            int osszeg = szam1 + szam2;
            Console.WriteLine($"A két szám összege {osszeg}");*/


            /*int osszeg = 0;
            int darabszam = 0;
            int szam = 0;

            while (osszeg <= 100)
            {
                Console.Write("Kérek egy pozitív egész számot: ");
                 szam = Convert.ToInt32(Console.ReadLine());
                osszeg += szam;
                darabszam++;
            }

            Console.WriteLine($"A számok darabszáma: {--darabszam}, összegük: {osszeg-szam}");*/


            /*string kimenet = "";
            int stringhossz = 0;
            int darabszam = 0;
            Console.Write("Milyen hosszú lehet a string? ");
            int ekkoralehetastring = Int32.Parse(Console.ReadLine());

            while (stringhossz <= ekkoralehetastring)
            {
                Console.Write("Kérek egy stringet: ");
                string beker = Console.ReadLine();
                int hossz = beker.Length;
                if (stringhossz + hossz <= ekkoralehetastring)
                {
                    stringhossz += hossz;
                    kimenet += beker;
                    darabszam++;
                }
                else
                {
                    break;
                }
                Console.WriteLine($"A bekért string száma: {darabszam}.");
                Console.WriteLine($"Az eredő string: {kimenet}");

            }*/




            /*Console.WriteLine("Kérek egy számot 1 és 20 között: ");
            int szam = Int32.Parse(Console.ReadLine());

            int faktorialis = 1;
            int index = 1;

            do
            {
                faktorialis *= index++;
                
            } while (index <= szam);

            Console.WriteLine($"{szam}! = {faktorialis}");*/

            // Binomiális együtthatók: n >=k >= 0 esetén




            /*for (int k = 1; k < 7; k++)
            {
                Console.SetCursorPosition(k * 7, 0);
                Console.Write($"k = {k - 1}");
            }

            for (int n = 1; n < 7 ; n++)
            {
                Console.SetCursorPosition(0, n);
                Console.Write($"n = {n - 1}");
            }

            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.SetCursorPosition(j * 7, i);
                    int fakt = faktorialisszamitas(i - 1) / (faktorialisszamitas(j - 1) * faktorialisszamitas(i - j));
                    Console.Write(fakt);
                }
            }*/

            /*for (int i = 1; i <= 20; i++)
            {
                if (i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*for (int i = 1; i <= 20; i++)
            {
                if (i % 5 == 0)
                {
                    goto ide;
                }
                Console.WriteLine(i);
            }

            ide:
            Console.WriteLine("Itt ér véget a mese");*/


            /*Console.Write("Adj meg egy napot a hét napjai közül: ");
            string nap = Console.ReadLine();

            switch (nap)
            {
                case "Hétfő":
                    
                    
                case "Kedd":
                    
                case "Szerda":
                    
                case "Csütörtök":
                    Console.WriteLine("Szeretem a hétköznapokat!");
                    break;
                case "Péntek":
                    Console.WriteLine("Majdnem hétvége!");
                    break;
                case "Szombat":
                    
                case "Vasárnap":
                    Console.WriteLine("Hurrá hétvége!");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen nap!");
                    break;
            }
            */
            /*Console.Write("Adj meg egy számot 1 és 10 között: ");
            string szam = Console.ReadLine();

            switch (szam)
            {
                case "0":
                    Console.WriteLine("Ez a szám páros");
                    break;
                case "1":
                    Console.WriteLine("Ez a szám páros");
                    break;
                case "3":
                    Console.WriteLine("Ez a szám páratlan");
                    break;
                case "4":
                    Console.WriteLine("Ez a szám páros");
                    break;
                case "5":
                    Console.WriteLine("Ez a szám páratlan");
                    break;
                case "6":
                    Console.WriteLine("Ez a szám páros");
                    break;
                case "7":
                    Console.WriteLine("Ez a szám páratlan");
                    break;
                case "8":
                    Console.WriteLine("Ez a szám páros");
                    break;
                case "9":
                    Console.WriteLine("Ez a szám páratlan");
                    break;
                case "10":
                    Console.WriteLine("Ez a szám páros");
                    break;

            }*/







            Console.ReadKey(true);
        }

        static int faktorialisszamitas(int szam)
        {
            
            int faktorialis = 1;
            int index = 1;

            do
            {
                faktorialis *= index++;

            } while (index <= szam);
            return faktorialis;

        }


    }
}
