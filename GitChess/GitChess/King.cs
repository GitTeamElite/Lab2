using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class King : Piece // Done
    {
        public King(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " K ";
            this.Points = 10;
            this._ImAlive = true;
        }
        public override void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY) // Checking base move rules         
        {

            if (!base.CheckMove(BlacksTurn, BlackIsEnemy, Board, CurrentX, CurrentY, MovingX, MovingY)) { return false; }

            if (Board[CurrentX + 1, CurrentY]._ImAlive == false) { AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY, 0)); return true; }     //Check move x+1, y

            if (Board[CurrentX - 1, CurrentY]._ImAlive == false || Board[CurrentX - 1, CurrentY]._ImBlack != BlackIsEnemy)
            { AvilibleMoves.Add(new Move(CurrentX - 1, CurrentY, 0)); return true; }  //Check move x-1, y

            if (Board[CurrentX, CurrentY + 1]._ImAlive == false || Board[CurrentX, CurrentY + 1]._ImBlack != BlackIsEnemy)
            { AvilibleMoves.Add(new Move(CurrentX, CurrentY + 1, 0)); return true; }   //Check move x, y+1

            if (Board[CurrentX, CurrentY - 1]._ImAlive == false|| Board[CurrentX, CurrentY - 1]._ImBlack != BlackIsEnemy)
            { AvilibleMoves.Add(new Move(CurrentX, CurrentY - 1, 0)); return true; }   //Check move x, y-1

            if (Board[CurrentX + 1, CurrentY + 1]._ImAlive == false|| Board[CurrentX + 1, CurrentY + 1]._ImBlack!=BlackIsEnemy)
            { AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY + 1, 0)); return true; }   //Check move x+1, y+1

            if (Board[CurrentX - 1, CurrentY - 1]._ImAlive == false|| Board[CurrentX - 1, CurrentY - 1]._ImBlack!=BlackIsEnemy)
            { AvilibleMoves.Add(new Move(CurrentX - 1, CurrentY - 1, 0)); return true; }  //Check move x-1, y-1

            if (Board[CurrentX + 1, CurrentY - 1]._ImAlive == false|| Board[CurrentX + 1, CurrentY - 1]._ImBlack!=BlackIsEnemy)
            { AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY - 1, 0)); return true; }   //Check move x+1, y-1

            if (CurrentX > 7)
            {
                if (Board[CurrentX + 1, CurrentY]._ImAlive == false || Board[CurrentX + 1, CurrentY]._ImBlack != BlacksTurn) //Check move x+1, y
                { AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY)); }
            }
            if (CurrentX > 0)
            {
                if (Board[CurrentX - 1, CurrentY]._ImAlive == false || Board[CurrentX - 1, CurrentY]._ImBlack != BlacksTurn) //Check move x-1, y
                { AvilibleMoves.Add(new Move(CurrentX - 1, CurrentY)); }
            }
            if (CurrentY < 7)
            {
                if (Board[CurrentX, CurrentY + 1]._ImAlive == false || Board[CurrentX, CurrentY + 1]._ImBlack != BlacksTurn) //Check move x, y+1
                { AvilibleMoves.Add(new Move(CurrentX, CurrentY + 1)); }
            }
            if (CurrentY > 0)
            {
                if (Board[CurrentX, CurrentY - 1]._ImAlive == false || Board[CurrentX, CurrentY - 1]._ImBlack != BlacksTurn)   //Check move x, y-1
                { AvilibleMoves.Add(new Move(CurrentX, CurrentY - 1)); }


            }
            if (CurrentX > 0 && CurrentY > 0)
            {
                if (Board[CurrentX - 1, CurrentY - 1]._ImAlive == false || Board[CurrentX - 1, CurrentY - 1]._ImBlack != BlacksTurn)//Check move x-1, y-1
                { AvilibleMoves.Add(new Move(CurrentX - 1, CurrentY - 1)); }

            }
            if (CurrentX < 7 && CurrentY > 0)
            {
                if (Board[CurrentX + 1, CurrentY - 1]._ImAlive == false || Board[CurrentX + 1, CurrentY - 1]._ImBlack != BlacksTurn)//Check move x+1, y-1
                {
                }
                AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY - 1));
            }

            if (CurrentX > 0 && CurrentY < 7)
            {
                if (Board[CurrentX - 1, CurrentY + 1]._ImAlive == false || Board[CurrentX - 1, CurrentY + 1]._ImBlack != BlacksTurn) //Check move x-1, y+1
                { AvilibleMoves.Add(new Move(CurrentX - 1, CurrentY + 1)); }
            }
        }

    }
}
