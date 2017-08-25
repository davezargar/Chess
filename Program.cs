using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Board = new string[8, 8];

            string borderTop = "-";
            string borderSide = "|";
            string empty = "_";

            Board[0, 0] = "/";
            Board[0, 7] = "d";
            Board[7, 0] = "<";
            Board[7, 7] = ">";


            Board[0, 1] = borderTop;
            Board[0, 2] = borderTop;
            Board[0, 3] = borderTop;
            Board[0, 4] = borderTop;
            Board[0, 5] = borderTop;
            Board[0, 6] = borderTop;

            Board[7, 1] = borderTop;
            Board[7, 2] = borderTop;
            Board[7, 3] = borderTop;
            Board[7, 4] = borderTop;
            Board[7, 5] = borderTop;
            Board[7, 6] = borderTop;
           


            Board[1, 0] = borderSide;
            Board[2, 0] = borderSide;
            Board[3, 0] = borderSide;
            Board[4, 0] = borderSide;
            Board[5, 0] = borderSide;
            Board[6, 0] = borderSide;
            
            Board[1, 7] = borderSide;
            Board[2, 7] = borderSide;
            Board[3, 7] = borderSide;
            Board[4, 7] = borderSide;
            Board[5, 7] = borderSide;
            Board[6, 7] = borderSide;

            int b = 1;
            int z = 1;

            for (int i = 0; i <= 32; i++) {
                if (b >= 6)
                {
                    b = 1;
                    Board[z, b] = empty;
                    z++;
                }
                else if (z == 6)
                {
                    z = 1;
                }
                Board[z, b] = empty;
                b++;
            }

            int y = 0;
            int x = 0;
            for (int i = 0; i <= 64; i++)
            {
                if (y >= 7 && x > 7)
                {
                    Console.WriteLine("error");
                    break;
                }
                else if (x >= 8)
                {
                    x = 0;
                    y++;
                    Console.WriteLine("\n" + Board[y, x]);
                    //Console.Write("\n" + y + "," + x + " " );
                    x++;
                }
                else
                {
                    Console.Write(Board[y, x]);
                    //Console.Write(y + "," + x + " ");
                    x++;
                }
            }

            Console.ReadKey();
        }
    }
}
