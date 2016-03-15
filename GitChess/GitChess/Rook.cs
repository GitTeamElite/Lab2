using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Rook : Piece
    {
        public Rook(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " R ";
        }
        public  void CheckMove(bool BlacksTurn, bool BlackIsEnemy, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY)
        {

            MoveStraight(BlacksTurn, BlackIsEnemy, Board, CurrentX, CurrentY, MovingX, MovingY);
            

         
        
        }
    }
}
