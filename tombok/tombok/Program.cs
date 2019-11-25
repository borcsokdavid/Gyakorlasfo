using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*42. - 43.Feladat

            Console.Write("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());
            

            int[] tomb = new int[darabszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            int paratlanokszama = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 1)
                {
                    paratlanokszama++;
                }
            }

            Console.WriteLine($"A tömbben található páratlan számok száma: {paratlanokszama}");



            //Páros számog összege.
            int parosokosszege = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    parosokosszege += tomb[i];
                }
            }
            Console.WriteLine($"A páros számok összege: {parosokosszege}");*/

            /*44.Feladat

            Console.Write("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());
            int[] tomb = new int[darabszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1} számot.");
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    Console.WriteLine(i + 1 + ". szám páros"+tomb[i]);
                }
            }*/

            /*45.Feladat

            Console.Write("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());
            int[] tomb = new int[darabszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            Console.Write("Kérem a próbaszámot");
            int probaszam = Convert.ToInt32(Console.ReadLine());
            int tombindex = -1;
            bool vane = false;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probaszam)
                {
                    tombindex = i + 1;
                    vane = true;
                    break;
                }
            }

            if (vane)
            {
                Console.WriteLine($"Találtam ilyen számot a(z) {tombindex} pozícióban.");
            }
            else
            {
                Console.WriteLine("Nincs ilyen szám a tömben");
            }*/

            /*46.Feladat

            Console.Write("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());
            int[] tomb = new int[darabszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            Console.Write("Kérem a próbaszámot");
            int probaszam = Convert.ToInt32(Console.ReadLine());
            int szamlalo = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probaszam)
                {
                    szamlalo++;
                }
            }

            if (szamlalo != 0)
            {
                Console.WriteLine($"A(z) {probaszam} ennyiszer szerepel: {szamlalo}");
            }

            else
            {
                Console.WriteLine("Ilyen szám nincs a tömbben.");
            }*/

            /*47.Feladat
            Console.Write("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());
            string[] tomb = new string[darabszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. nevet: ");
                string keresztnev = Console.ReadLine();
                tomb[i] = keresztnev;
            }

            Console.Write("Kérem a próbanevet");
            string probanev = Console.ReadLine();
            int szamlalo = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probanev)
                {
                    szamlalo++;
                }
            }

            if (szamlalo != 0)
            {
                Console.WriteLine($"A(z) {probanev} ennyiszer szerepel: {szamlalo}");
            }

            else
            {
                Console.WriteLine("Ilyen név nincs a tömbben.");
            }*/

            //48.Feladat

            Console.Write("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());
            int[] tomb = new int[darabszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            int maxkulonbség = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    int kulonbség = Math.Abs(tomb[i] - tomb[j]);
                    if (maxkulonbség <= kulonbség)
                    {
                        maxkulonbség = kulonbség;
                    }
                }
            }

            Console.WriteLine("Különbség: " + maxkulonbség);





            //tombkiir(tomb);
            Array.Sort(tomb);
            //tombkiir(tomb);


            Console.WriteLine($"A különbség: {tomb[tomb.Length - 1] - tomb[0]}");

            Console.WriteLine($"A külnöbség: {tomb.Max() - tomb.Min()}");








            Console.ReadKey(true);
        }
        static void tombkiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
        }
    }
}





