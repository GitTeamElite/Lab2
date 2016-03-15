using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Bishop : Piece
    {

        public Bishop(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " B ";
        }
        public void CheckMove(bool BlacksTurn, bool BlackIsEnemy, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY)
        {

            MoveDiagonaly(BlacksTurn, BlackIsEnemy, Board, CurrentX, CurrentY, MovingX, MovingY);
            
        }
    }
}
