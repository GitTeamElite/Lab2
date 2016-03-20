using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Rules
    {
        List<Move> MovesBlack;
        List<Move> MovesWhite;
        List<Move> UsingList;
        List<Piece> Pieces;
        Piece[,] Board;

        public Rules()
        {
            this.MovesBlack = new List<Move>();
            this.MovesWhite = new List<Move>();
            this.UsingList = new List<Move>();
        }
        public void ChackMatt(Piece[,]Board,bool BlacksTurn)
        {
            if (BlacksTurn) { UsingList = MovesWhite;  }
            else { UsingList = MovesBlack; }

            foreach (var item in UsingList)
            {
                if (Board[item.YMove, item.XMove]._MyVisualLook == " K " )
                {
                    // Då är din kung i schack och måste flyttas!
                    // MustMoveKing!!

                // if Cant... end!
                }
            }
        }
        public void FillListMoves(Piece[,] Board)
        {
            foreach (var item in Board)
            {
                if (item._ImBlack && item._ImAlive)
                {
                    foreach (var item2 in item.AvilibleMoves)
                    {
                        MovesBlack.Add(item2);
                    }
                }
                else if (!item._ImBlack && item._ImAlive)
                {
                    foreach (var item2 in item.AvilibleMoves)
                    {
                        MovesWhite.Add(item2);
                    }
                }
            }
        }
        
    }
}
