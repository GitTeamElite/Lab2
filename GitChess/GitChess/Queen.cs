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
            this._ImAlive = true;
        }
        public override void CheckMove(bool BlacksTurn , Piece[,] Board, int CurrentX, int CurrentY  )
        {
            MoveStraight(BlacksTurn, Board, CurrentX, CurrentY );
            MoveDiagonaly(BlacksTurn, Board, CurrentX, CurrentY);
        
        }
    }
}
