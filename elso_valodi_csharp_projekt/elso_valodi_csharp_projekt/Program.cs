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

            /*16.Feladat

            Console.Write("Írj be egy számot ");
            int s = Convert.ToInt32(Console.ReadLine());
            //string kiiratas = "";

            /*for (int i = 0; i < s; i++)
            {
                Console.WriteLine(i);
            }*/

            /*int i = 1;*/

            /*while (i < s)
            {
                Console.WriteLine(i++);
            }*/


            /*do
            {
                Console.WriteLine(i);
            } while (i < s);*/

            /*17.Feladat
            Console.Write("Írj be egy számot ");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{s} egész osztói: ");

            /*for (int i = 1; i <= s; i++)
            {
                if (s % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            int i = 1;
            while (i <= s)
            {
                if (s % i == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
                
            }*/


            /*+Feladat

            Console.Write("Írj be egy számot ");
            int s = Convert.ToInt32(Console.ReadLine());
            int szamlalo = 0;

            for (int i = 1; i < s + 1; i++)
            {
                if (s % i == 0)
                {
                    szamlalo++;
                }
            }
            if (szamlalo == 2)
            {
                Console.WriteLine($" A bemenő szám {s} prím.");
            }
            else
            {
                Console.WriteLine($"A bemenő szám {s} nem prím.");
            }*/

            /*18.Feladat
            Console.Write("Írj be egy számot ");
            int s = Convert.ToInt32(Console.ReadLine());
            int szamlalo = 0;
            int osztokosszege = 0;


            for (int i = 0; i < s + 1; i++)
            {
                if (s % i == 0)
                {
                    szamlalo++;
                    osztokosszege += 1;
                }
            }

            if (szamlalo == 2)
            {
                Console.WriteLine($"A bemenő szám {s} osztóinak összege: {osztokosszege}");
            }
            else
            {
                Console.WriteLine($"A bemenő szám {s} osztóinak összege: {osztokosszege}");
            }*/


            /*19.Feladat
            Console.Write("Írj be egy számot ");
            int s = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int osztokosszege = 0;

            while (i < s)
            {
                if (s % i == 0)
                {
                    osztokosszege += i;
                }
                i++;
            }

            if (osztokosszege  == s)
            {
                Console.WriteLine($"A szám {s} tökéletes szám.");
            }
            else
            {
                Console.WriteLine($"A szám {s} nem tökéletes szám.");
            }*/

            /*20.Feladat
            int alap = -1;
            while (alap <= 0 || alap > 10)
            {
                Console.Write("Kérem az alapot: ");
                alap = Convert.ToInt32(Console.ReadLine());
            }

            int kitevo = -1;
            while (kitevo <=0 || kitevo > 10)
            {
                Console.Write("Kérem a kitevőt: ");
                kitevo = Convert.ToInt32(Console.ReadLine());
            }
            
            int hatvany = 1;

            for (int i = 0; i < kitevo ; i++)
            {
                hatvany *= alap;
            }
            Console.Write($"A hatvány {hatvany}");*/


            /*21.Feladat
            int szam = -1;
            while (szam <= 0 ) 
            {
                Console.Write("Kérem egy pozitív egész számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(szam);

            int szam = 1;
            while (szam % 2 == 1 || szam  == -1)
            {
                Console.WriteLine($"Kérem az alapot");
                szam = Convert.ToInt32(Console.ReadLine());
            }*/

            /*Plusz feladat: Prímszámra lépjen ki a ciklusból

            int szam = 3;

            while (primszamE(szam))
            {
                Console.Write("Kérek egy nem prímszámot");
                szam = Convert.ToInt32(Console.ReadLine());
            }*/

            /*22.Feladat

            int szam = 0;
            int osszeg = 0;

            while (szam <= 10)
            {
                
                Console.Write("Kérek egy 10-nél kisebb egésez számot: ");
                szam = Int32.Parse(Console.ReadLine());
                if (szam <= 10)
                {
                    osszeg += szam;
                    Console.WriteLine($"Az eddig beolvasott  megfelelő számok összege {osszeg}.");
                }
                else
                {
                    Console.WriteLine("Nem megfelelő szám!");
                    break;
                }
            }


            Console.WriteLine($"A beolvasott számok összege: {osszeg}");*/

            /*36.Feladat
            Console.Write("Kérem a sorok számát: ");
            int sorok = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem az oszlopok számát: ");
            int oszlopok = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write('O');
                    }
                }
                Console.WriteLine();
            }*/

            /*37.Feladat
            Console.Write("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < szam; i++)
            {
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }*/

            /*38.Feladat
            Console.WriteLine("Kérem a sorok számát: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.SetCursorPosition(20 - i, i + 2);
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }*/

            /*39.Fleadat


            Console.Write("Kérem a sorok számát: ");
            int sorok = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem az oszlopok számát: ");
            int oszlopok = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if ((i == 0) || (i == (sorok - 1)) || (i == (sorok -1) / 2))
                    {
                        Console.Write('*');
                    }
                    else if ((j == 0) || (j == oszlopok - 1) || (j == (oszlopok - 1) / 2))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                    
                }*/

            /*41.Feladat

            for (int i = 65; i < 91; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();
            for (int j = 66; j < 91; j++)
            {
                Console.Write((char)j);
            }
            for (int k = 65; k < 66; k++)
            {
                Console.Write((char)k);
            }*/

            for (int i = 0; i < 27; i++)
            {
                for (int j = 65 + i ; j < 91; j++)
                {
                    Console.Write((char)j);
                }

                for (int k = 65; k < 65 + i; k++)
                {
                    Console.Write((char)k);
                }
                Console.WriteLine();
            }




















            Console.ReadKey(true);
        }
    }
}

        /*static bool primszamE(int szam)
        {
            bool teljesul = true;

            int osztokSzama = 0;

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    osztokSzama++;
                }
            }

            if (osztokSzama == 2)
            {
                return teljesul;
            }
            else
            {
                return !teljesul;
            }
        }

        }
    }*/

