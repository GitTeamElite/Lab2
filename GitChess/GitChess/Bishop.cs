using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Bishop :Piece
    {

        public Bishop(bool _ImBlack):base(_ImBlack)
        {
            this._MyVisualLook = " B ";
        }
        public override bool CheckMove(int x, int y)
        {


            return true;
        }
    }
}
