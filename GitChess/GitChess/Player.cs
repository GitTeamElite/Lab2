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

        //Check if piece choosen is mine + Check legality of the movement ex: A2 --> A4 (Pawn)
        public void MovePiece(int moveX, int moveY, Piece[,] chessBoard)
        {


            int Xdärdenstår = 0;
            int Ydärdenstår = 0;
            foreach (var item in chessBoard[Xdärdenstår, Ydärdenstår].AvilibleMoves)//Xdärdenstår,Ydärdenstår introduced by the user in TheGame Class
            {
                if ((item.XMove == moveX) && (item.YMove == moveY))
                {

                }


            }

        }
        //public void CheckThretenPieces(Piece[,] chessBoard)
        //{
        //    for (int x = 0; x < chessBoard.Length; x++)
        //    {
        //        for (int y = 0; y < chessBoard.Length; y++)
        //        {
        //            if ( )
        //        }
        //    }

        //}
        public void CheckAvilibleMoves()
        {

        }
        public void Move(bool BlacksTurn, Piece[,] Board)
        {
            bool PieceMoved = false;
            while (!PieceMoved)
            {
                Console.WriteLine("Test pick y");
                int a = 0;
                int.TryParse(Console.ReadLine(), out a);
                a -= 1;
                Console.WriteLine("Test pick x");
                int b = 0;
                int.TryParse(Console.ReadLine(), out b);
                b -= 1;

                int y = 0;
                Console.WriteLine("Test move to y");
                int.TryParse(Console.ReadLine(), out y);
                int x = 0;
                Console.WriteLine("Test move to x");
                int.TryParse(Console.ReadLine(), out x);
                if (a > 0 && b > 0 && y > 0 && x > 0)
                {
                    if (BlacksTurn)
                    {
                        if (Board[a, b]._ImBlack && Board[a, b]._ImAlive)
                        {

                            if (Board[a, b].CheckMoveTry(x, y))
                            {
                                Board[x, y] = Board[a, b];
                                Board[a, b] = null;
                                Board[a, b] = new Piece(true);
                                Board[a, b]._ImAlive = false;
                                PieceMoved = true;
                            }
                        }
                        Console.WriteLine("Not your piece!");
                        Console.ReadKey();
                    }
                    else if (!BlacksTurn)
                    {
                        if (!Board[a, b]._ImBlack && Board[a, b]._ImAlive)
                        {

                            if (Board[a, b].CheckMoveTry(x, y))
                            {
                                Board[x, y] = Board[a, b];
                                Board[a, b] = null;
                                Board[a, b] = new Piece(true);
                                Board[a, b]._ImAlive = false;
                                PieceMoved = true;
                            }
                        }
                        Console.WriteLine("Not your piece!");
                        Console.ReadKey();
                    }
                }
                else { Console.WriteLine("Wrong input!"); Console.ReadKey(); }
            }
        }
    }
}
