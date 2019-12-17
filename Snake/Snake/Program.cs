using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;
            //Console.WriteLine($"{szelesseg} és {magassag}");

            int x = szelesseg / 2;
            int y = magassag / 2;

            int[] xkord = new int[5];
            int[] ykord = new int[5];

            int[] pontokx = new int[10];
            int[] pontoky = new int[10];


            for (int i = 0; i < 5; i++)
            {
                xkord[i] = x + i;
                ykord[i] = y;

            }

            for (int i = 0; i < 10; i++)
            {
                pontokx[i] = rnd.Next(0, szelesseg);
                pontoky[i] = rnd.Next(0, magassag);
            }

            megrajzol(pontokx, pontoky);
            megrajzol(xkord, ykord);



            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            while (cki.Key != ConsoleKey.Escape)
            {

                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        megrajzol(pontokx, pontoky);
                        baloldalra(ref xkord, ref ykord);
                        Console.SetCursorPosition(x, y);
                        megrajzol(xkord, ykord);
                        for (int i = 0; i < pontokx.Length; i++)
                        {
                            if (pontokx[i] == xkord[xkord.Length - 1] && pontoky[i] == ykord[ykord.Length - 1])
                            {
                                pontokx = eggyelcsokkent(pontokx[i] , pontokx);
                                pontoky = eggyelcsokkent(pontoky[i] , pontoky);
                            }
                        }

                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        megrajzol(pontokx, pontoky);
                        felfele(ref xkord, ref ykord);
                        Console.SetCursorPosition(x, y);
                        megrajzol(xkord, ykord);
                        for (int i = 0; i < pontokx.Length; i++)
                        {
                            if (pontokx[i] == xkord[xkord.Length - 1] && pontoky[i] == ykord[ykord.Length - 1])
                            {
                                pontokx = eggyelcsokkent(pontokx[i], pontokx);
                                pontoky = eggyelcsokkent(pontoky[i], pontoky);
                            }
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        megrajzol(pontokx, pontoky);
                        jobboldalra(ref xkord, ref ykord);
                        Console.SetCursorPosition(x, y);
                        megrajzol(xkord, ykord);
                        for (int i = 0; i < pontokx.Length; i++)
                        {
                            if (pontokx[i] == xkord[xkord.Length - 1] && pontoky[i] == ykord[ykord.Length - 1])
                            {
                                pontokx = eggyelcsokkent(pontokx[i], pontokx);
                                pontoky = eggyelcsokkent(pontoky[i], pontoky);
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        megrajzol(pontokx, pontoky);
                        lefele(ref xkord, ref ykord);
                        Console.SetCursorPosition(x, y);
                        megrajzol(xkord, ykord);
                        for (int i = 0; i < pontokx.Length; i++)
                        {
                            if (pontokx[i] == xkord[xkord.Length - 1] && pontoky[i] == ykord[ykord.Length - 1])
                            {
                                pontokx = eggyelcsokkent(pontokx[i], pontokx);
                                pontoky = eggyelcsokkent(pontoky[i], pontoky);
                            }
                        }
                        break;
                }
            }



            Console.ReadKey(true);
        }

        static void megrajzol(int[] x, int[] y)
        {
            for (int i = 0; i < x.Length; i++)
            {

                Console.SetCursorPosition(x[i], y[i]);
                Console.Write('*');
            }
        }
        static void lefele(ref int[] x, ref int[] y)
        {
            int[] atmenetx = x;
            int[] atmenety = y;
            for (int i = 0; i < 4; i++)
            {
                x[i] = atmenetx[i + 1];
                y[i] = atmenety[i + 1];
            }
            x[4] = atmenetx[4];
            y[4] = atmenety[4] + 1;
        }
        static void jobboldalra(ref int[] x, ref int[] y)
        {
            int[] atmenetx = x;
            int[] atmenety = y;
            for (int i = 0; i < 4; i++)
            {
                x[i] = atmenetx[i + 1];
                y[i] = atmenety[i + 1];
            }
            x[4] = atmenetx[4] + 1;
            y[4] = atmenety[4];
        }
        static void baloldalra(ref int[] x, ref int[] y)
        {
            int[] atmenetx = x;
            int[] atmenety = y;
            for (int i = 0; i < 4; i++)
            {
                x[i] = atmenetx[i + 1];
                y[i] = atmenety[i + 1];
            }
            x[4] = atmenetx[4] - 1;
            y[4] = atmenety[4];
        }
        static void felfele(ref int[] x, ref int[] y)
        {
            int[] atmenetx = x;
            int[] atmenety = y;
            for (int i = 0; i < 4; i++)
            {
                x[i] = atmenetx[i + 1];
                y[i] = atmenety[i + 1];
            }
            x[4] = atmenetx[4];
            y[4] = atmenety[4] - 1;



        }
        
        static int[] eggyelcsokkent(int szam, int[] a)
        {
            int[] b = new int[a.Length - 1];
            for (int i = 0; i < b.Length; i++)
            {
                if (szam != a[i])
                {
                    b[i] = a[i];
                }
                else if (szam == a[i] && i != a.Length - 1)
                {
                    b[i] = a[i + 1];
                    i++;
                }
                else
                {
                    break;
                }
            }

            return b;
        }
        
        
    }
}