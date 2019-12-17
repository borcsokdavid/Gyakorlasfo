using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacifeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int bekertszam = 0;
            Random rnd = new Random();

            while (bekertszam <= 0)
            {
                try
                {
                    Console.Write("Adj meg egy egész számot: ");
                    bekertszam = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            
            //Console.WriteLine($"A bekért szám: {bekertszam}");

            int[] veletenszamok = new int[bekertszam];

            Console.Write("\nA generált számok: ");

            int osszeg = 0;
            int szorzat = 1;
            int egymasbolkivon = rnd.Next(-100, 100);
            veletenszamok[0] = egymasbolkivon;
            osszeg += egymasbolkivon;
            szorzat *= egymasbolkivon;
            Console.Write($"{egymasbolkivon};");

            for (int i = 1; i < bekertszam; i++)
            {
                int generaltszam = rnd.Next(-100, 100);
                veletenszamok[i] = generaltszam;
                osszeg += generaltszam;
                szorzat *= generaltszam;
                egymasbolkivon -= generaltszam;
                if (i != bekertszam -1)
                {
                    Console.Write($"{generaltszam};");
                }
                else
                {
                    Console.Write(generaltszam);
                }
                Console.Write(generaltszam);
                
            }

            Console.WriteLine($"\n\nA generált számok összege: {osszeg}");
            Console.WriteLine($"A generált számok szorzata: {szorzat}");
            Console.WriteLine($"A generált értékek egymásból kivonva: {egymasbolkivon}");


            Console.ReadKey(true);
        }
    }
}
