using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class King : Piece
    {
        public King(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " K ";
        }
        public override bool CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY) // Checking base move rules         
        {
            // 1 move on all spots around

      



            return true;
        }
    }
}
