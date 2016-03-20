using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Rook : Piece
    {
        public Rook(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " R ";
            this._ImAlive = true;
            this.Points = 5;
        }
        public override void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY  )
        {
            MovingStraight(BlacksTurn, Board, CurrentX, CurrentY);       
        }
    }
}
