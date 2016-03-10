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
        public override bool CheckMove( int x, int y)
        {


            return true;
        }
    }
}
