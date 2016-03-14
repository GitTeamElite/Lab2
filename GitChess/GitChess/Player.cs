using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Player :Iplayer
    {

        public List<Piece> IplayPieceList;


        public Player()
        {
            //Browse his own all chessboard
            this.IplayPieceList = new List<Piece>();
        }
        public void MovePiece(int moveX, int moveY, Piece[,]chessBoard )
        {
            chessBoard[moveX, moveY] = 
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
