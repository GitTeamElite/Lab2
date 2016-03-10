using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Pawn : Piece
    {
        public Pawn(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " P ";
        }
        public int MovePawn(bool BlacksTurn)
        {
          
            if (BlacksTurn) { return 1; }
            else  { return -1; }
            
        }
    }
}
