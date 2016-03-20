using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Player
    {

        public List<Piece> IplayPieceList;
        bool _ImBlackPlayer;

        public Player()
        {
            //Browse his own all chessboard
            this.IplayPieceList = new List<Piece>();
        }


        public void CheckAvilibleMoves()
        {

        }
        public bool Move(bool BlacksTurn, Piece[,] Board,string WhitePiecesDied,string BlackPiecesDied,Logger logger)
        {
            Console.WriteLine("Choice a Piece to move!");
            Console.WriteLine("Test pick y");
            int a = 0;
            int.TryParse(Console.ReadLine(), out a);
            a -= 1;
            Console.WriteLine("Test pick x");
            int b = 0;
            int.TryParse(Console.ReadLine(), out b);
            b -= 1;

            if (a > -1 && b > -1 && a < 8 && b < 8)
            {
                Printer.PrintGameHighLights(Board, BlacksTurn, a, b,a,b);

                if (Board[a, b]._ImBlack == BlacksTurn && Board[a, b]._ImAlive)
                {
                    Board[a, b].PrintMoveList();
                    int y = 0;
                    Console.WriteLine("Test move to y");
                    int.TryParse(Console.ReadLine(), out y);
                    int x = 0;
                    Console.WriteLine("Test move to x");
                    int.TryParse(Console.ReadLine(), out x);
                    x -= 1;
                    y -= 1;
                    if (y > -1 && x > -1 && y < 8 && x < 8)
                    {
                        if (Board[a, b].CheckMoveTry(y, x))
                        {
                            logger.LoggDeaths(BlacksTurn, Board, y, x);

                            Board[y, x] = Board[a, b]; //test now
                            Board[a, b] = new Piece();
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Cant move like that!"); Console.ReadKey();
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input!"); Console.ReadKey();
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Not your piece!");
                    Console.ReadKey();
                    return false;
                }

            }
            else
            {
                Console.WriteLine("Wrong input!"); Console.ReadKey();
            }
            return false;
        }
    }
}
