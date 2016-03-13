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
            //+2x +1y || +2x -1y || -2x +1y || -2x -1y || +2y +1x || +2y -1x || -2y +1x || -2y -1x


            return true;
        }
    }
}
