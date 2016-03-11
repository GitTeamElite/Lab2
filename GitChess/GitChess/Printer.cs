using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    public static class Printer
    {
        public static void PrintGame(Piece[,] board)
        {
            Console.WriteLine("    1  2  3  4  5  6  7  8");
            Console.Write(" A ");
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (y % 2 == 0)
                    {
                        if (x % 2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                        }
                    }
                    else
                    {
                        if (x % 2 != 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                        }
                    }                                                   
                        if (board[x, y]._ImBlack == true) { Console.ForegroundColor = ConsoleColor.Black; Console.Write(board[x,y]._MyVisualLook); Console.ForegroundColor = ConsoleColor.White; }
                        else if (board[x, y]._ImBlack == false) { Console.ForegroundColor = ConsoleColor.Red; Console.Write(board[x,y]._MyVisualLook); Console.ForegroundColor = ConsoleColor.White; }
                }
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("\n" + StaticMethods.ReturnFrame(x));
            }
        }

    }
}
