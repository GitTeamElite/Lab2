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
            this.Points = 10;
        }
        public override bool CheckMove(bool BlacksTurn, bool BlackIsEnemy, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY) // Checking base move rules         
        {
            if (!base.CheckMove(BlacksTurn, BlackIsEnemy, Board, CurrentX, CurrentY, MovingX, MovingY)) { return false; }

            if (MovingX == CurrentX + 1 && MovingY == CurrentY ||      //Check move x+1, y
                MovingX == CurrentX - 1 && MovingY == CurrentY ||      //Check move x-1, y
                MovingX == CurrentX && MovingY == CurrentY + 1 ||      //Check move x, y+1
                MovingX == CurrentX && MovingY == CurrentY - 1 ||      //Check move x, y-1
                MovingX == CurrentX + 1 && MovingY == CurrentY + 1 ||  //Check move x+1, y+1
                MovingX == CurrentX - 1 && MovingY == CurrentY - 1 ||  //Check move x-1, y-1
                MovingX == CurrentX + 1 && MovingY == CurrentY - 1 ||  //Check move x+1, y-1
                MovingX == CurrentX - 1 && MovingY == CurrentY + 1)    //Check move x-1, y+1
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
