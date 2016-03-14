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
            foreach (var item in chessBoard[Xdärdenstår, Ydärdenstår].AvilibleMoves)//Xdärdenstår,Ydärdenstår introduced by the user in TheGame Class
            {
                if ((item.XMove == moveX) && (item.YMove == moveY))                
                    {

                    }

    
            }
            
        }
        public void CheckThretenPieces(Piece[,] chessBoard)
        {
            for (int x = 0; x < chessBoard.Length; x++)
            {
                for (int y = 0; y < chessBoard.Length; y++)
                {
                    if ( )
                }
            }

        }
        public void CheckAvilibleMoves()
        {

        }
    }
}
