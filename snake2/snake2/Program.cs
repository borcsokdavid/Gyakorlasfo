using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;
            //Console.WriteLine($"{szelesseg} és {magassag}");

            int x = szelesseg / 2;
            int y = magassag / 2;

            int[] xkord = new int[5];
            int[] ykord = new int[5];

            for (int i = 0; i < 5; i++)
            {
                xkord[i] = x + i;
                ykord[i] = y;
                
            }

            megrajzol(xkord, ykord);

            

            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            while (cki.Key != ConsoleKey.Escape)
            {
                
                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        baloldalra(ref xkord, ref ykord);
                        Console.SetCursorPosition(x, y);
                        megrajzol(xkord, ykord);

                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        felfele(ref xkord, ref ykord);
                        Console.SetCursorPosition(x, y);
                        megrajzol(xkord, ykord);
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        jobboldalra(ref xkord, ref ykord);
                        Console.SetCursorPosition(x, y);
                        megrajzol(xkord, ykord);
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        lefele(ref xkord, ref ykord);
                        Console.SetCursorPosition(x, y);
                        megrajzol(xkord, ykord);
                        break;
                }
            }

            

            Console.ReadKey(true);
        }

        static void megrajzol( int[] x, int[] y) 
        {
            for (int i = 0; i < 5; i++)
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
    }
}
