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
        public void MovePiece(int moveX, int moveY, Piece[,]chessBoard )
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
            Console.WriteLine("Test move y");
            int a = 0;
            int.TryParse(Console.ReadLine(), out a);
            a -= 1;
            Console.WriteLine("Test move x");
            int b = 0;
            int.TryParse(Console.ReadLine(), out b);
            b -= 1;

            if (BlacksTurn)
            {
                if (Board[a, b]._ImBlack && Board[a, b]._ImAlive)
                {
                    int y = 0;
                    int.TryParse(Console.ReadLine(), out y);
                    int x = 0;
                    int.TryParse(Console.ReadLine(), out x);
                    if (Board[a, b].CheckMoveTry(x, y))
                    {
                        Board[x, y] = Board[a, b];
                        Board[a, b] = null;
                        Board[a, b] = new Piece(true);
                        Board[a, b]._ImAlive = false;
                    }
                }
                Console.WriteLine("Not your piece!");
                Console.ReadKey();
            }
        }
    }
}
