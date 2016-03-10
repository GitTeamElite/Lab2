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
        public override bool CheckMove( int x, int y)
        {


            return true;
        }
    }
}
