using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Knight : Piece
    {
        public Knight(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " k ";
        }
        public override bool CheckMove(bool BlacksTurn, bool BlackIsEnemy, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY)
        {


            if (!base.CheckMove(BlacksTurn, BlackIsEnemy, Board, CurrentX, CurrentY, MovingX, MovingY)) { return false; } // Checking base rules

            if (MovingX == CurrentX + 2 && MovingY == CurrentY + 1 ||     //Check move x+2, y+1
               MovingX == CurrentX + 2 && MovingY == CurrentY - 1 ||      //Check move x+2, y-1
               MovingX == CurrentX - 2 && MovingY == CurrentY + 1 ||      //Check move x-2, y+1
               MovingX == CurrentX - 2 && MovingY == CurrentY - 1 ||      //Check move x-2, y-1
               MovingX == CurrentX + 1 && MovingY == CurrentY + 2 ||      //Check move x+1, y+2
               MovingX == CurrentX + 1 && MovingY == CurrentY + 2 ||      //Check move x-1, y+2
               MovingX == CurrentX + 1 && MovingY == CurrentY - 2 ||      //Check move x+1, y-2
               MovingX == CurrentX - 1 && MovingY == CurrentY - 2)        //Check move x-1, y-2
            {
                if (Board[MovingX, MovingY]._ImAlive == false)
                {
                    AvilibleMoves.Add(new Move(MovingX, MovingY, 0));
                    return true;
                }
                if (Board[MovingX, MovingY]._ImBlack != BlackIsEnemy)
                {
                    AvilibleMoves.Add(new Move(MovingX, MovingY, 0));
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }

        }
    }
}
