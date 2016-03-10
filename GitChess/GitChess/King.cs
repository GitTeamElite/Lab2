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
        public override bool CheckMove( int x, int y)
        {


            return true;
        }
    }
}
