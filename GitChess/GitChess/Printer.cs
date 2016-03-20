using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    public static class Printer
    {
        public static void PrintGame(Piece[,] board, bool BlacksTurn)
        {
            Console.Clear();
            if (BlacksTurn) { Console.WriteLine("Blacks turn"); } else { Console.WriteLine("Whites turn"); }

            Console.WriteLine("    x1 x2 x3 x4 x5 x6 x7 x8");
            Console.Write(" y1 ");
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
                    if (board[x, y]._ImBlack == true) { Console.ForegroundColor = ConsoleColor.Black; Console.Write(board[x, y]._MyVisualLook); Console.ForegroundColor = ConsoleColor.White; }
                    else if (board[x, y]._ImBlack == false) { Console.ForegroundColor = ConsoleColor.Red; Console.Write(board[x, y]._MyVisualLook); Console.ForegroundColor = ConsoleColor.White; }
                }
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("\n" + StaticMethods.ReturnFrame(x));
            }
        }
        public static void PrintGameHighLights(Piece[,] board, bool BlacksTurn, int a, int b,int aa,int bb)
        {
            Console.Clear();
            if (BlacksTurn) { Console.WriteLine("Blacks turn"); } else { Console.WriteLine("Whites turn"); }

            Console.WriteLine("    x1 x2 x3 x4 x5 x6 x7 x8");
            Console.Write(" y1 ");
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
                    if (board[x, y] == board[a, b] ) { Console.BackgroundColor = ConsoleColor.DarkBlue; }

                    if (board[a, b].CheckMoveTry(x, y)) { Console.BackgroundColor = ConsoleColor.Blue; }

                    if (board[x, y] == board[aa, bb]) { Console.BackgroundColor = ConsoleColor.DarkBlue; }
                    if (board[x, y]._ImBlack == true) { Console.ForegroundColor = ConsoleColor.Black; Console.Write(board[x, y]._MyVisualLook); Console.ForegroundColor = ConsoleColor.White; }
                        else if (board[x, y]._ImBlack == false) { Console.ForegroundColor = ConsoleColor.Red; Console.Write(board[x, y]._MyVisualLook); Console.ForegroundColor = ConsoleColor.White; }
                }
                Console.BackgroundColor = ConsoleColor.Black; Console.Write("\n" + StaticMethods.ReturnFrame(x));
            }
        }

    }
}
