using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class ChessBoard
    {
       public Piece[,] Board;

        public ChessBoard()
        {
            this.Board = new Piece[8, 8];
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    this.Board[x, y] = new Piece(true);
                }
            }
            int X = 0; while (X < 8)
            {
                this.Board[1, X] = new Pawn(true);
                this.Board[6, X] = new Pawn(false);
                X++;
            }
            // Rocks
            this.Board[0, 0] = new Rook(true);
            this.Board[0, 7] = new Rook(true);
            this.Board[7, 0] = new Rook(false);
            this.Board[7, 7] = new Rook(false);
            // Knights
            this.Board[0, 1] = new Knight(true);
            this.Board[0, 6] = new Knight(true);
            this.Board[7, 1] = new Knight(false);
            this.Board[7, 6] = new Knight(false);
            // Bishop
            this.Board[0, 2] = new Bishop(true);
            this.Board[0, 5] = new Bishop(true);
            this.Board[7, 2] = new Bishop(false);
            this.Board[7, 5] = new Bishop(false);
            // Queen
            this.Board[0, 3] = new Queen(true);
            this.Board[7, 3] = new Queen(false);
            // King
            this.Board[0, 4] = new King(true);
            this.Board[7, 4] = new King(false);
        }
        public Piece[,] GetBoard()
        {
            return Board;
        }
        public void MovePiece(int a,int b,int x,int y)
        {
            Board[x, y] = Board[a, b];
        }
      
}
}
