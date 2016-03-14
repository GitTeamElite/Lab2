using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Rook:Piece
    {
        public Rook(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " R ";
        }
        public override bool CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY)
        {
            // if (Board[x,y] == XMove

            return true;
        }
    }
}
