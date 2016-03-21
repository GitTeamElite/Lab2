using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Bishop : Piece
    {
        public Bishop(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " B ";
            this._ImAlive = true;
            this.Points = 5;
        }
        public override void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {
            MovingDiagonaly(BlacksTurn, Board, CurrentX, CurrentY);
        }
       
       
    }
}
