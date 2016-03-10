using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Queen:Piece
    {
        public Queen(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " Q ";
        }
        public override bool CheckMove( int x, int y)
        {


            return true;
        }
    }
}
