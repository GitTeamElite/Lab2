using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Knight: Piece
    {
        public Knight(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " k ";
        }
        public override bool CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY)
        {
            //+2x +1y || +2x -1y || -2x +1y || -2x -1y || +2y +1x || +2y -1x || -2y +1x || -2y -1x
      
            if (!base.CheckMove(BlacksTurn, Board, CurrentX, CurrentY, MovingX, MovingY)) { return false; } // Checking base rules

            return true;
        }
    }
}
