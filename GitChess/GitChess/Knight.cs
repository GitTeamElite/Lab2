using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Knight : Piece // Done
    {
        public Knight(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " k ";
        }
        public override void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {

            if (CurrentX < 6 && CurrentY < 7)
            {
                if (Board[CurrentX + 2, CurrentY + 1]._ImAlive == false || Board[CurrentX + 2, CurrentY + 1]._ImBlack != BlacksTurn)  //Check move x+2, y+1 

                {
                    this.AvilibleMoves.Add(new Move(CurrentX + 2, CurrentY + 1));
                }
            }

            if (CurrentX < 6 && CurrentY > 0)
            {
                if (Board[CurrentX + 2, CurrentY - 1]._ImAlive == false || Board[CurrentX + 2, CurrentY - 1]._ImAlive != BlacksTurn)  //Check move x+2, y-1
                {
                    this.AvilibleMoves.Add(new Move(CurrentX + 2, CurrentY - 1));
                }
            }
            if (CurrentX > 1 && CurrentY < 7)
            {
                if (Board[CurrentX - 2, CurrentY + 1]._ImAlive == false || Board[CurrentX - 2, CurrentY + 1]._ImBlack != BlacksTurn)  //Check CurrentX  &&  CurrentY x-2, y+1
                {
                    this.AvilibleMoves.Add(new Move(CurrentX - 2, CurrentY + 1));
                }
            }
            if (CurrentX > 1 && CurrentY > 0)
            {
                if (Board[CurrentX - 2, CurrentY - 1]._ImAlive == false || Board[CurrentX - 2, CurrentY - 1]._ImBlack != BlacksTurn)  //Check move x-2, y-1
                {
                    this.AvilibleMoves.Add(new Move(CurrentX - 2, CurrentY - 1));
                }
            }
            if (CurrentX < 7 && CurrentY < 6)
            {
                if (Board[CurrentX + 1, CurrentY + 2]._ImAlive == false || Board[CurrentX + 1, CurrentY + 2]._ImBlack != BlacksTurn)   //Check move x+1, y+2
                {
                    this.AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY + 2));
                }
            }
            if (CurrentX > 0 && CurrentY < 6)
            {
                if (Board[CurrentX - 1, CurrentY + 2]._ImAlive == false || Board[CurrentX - 1, CurrentY + 2]._ImBlack != BlacksTurn)  //Check move x-1, y+2
                {
                    this.AvilibleMoves.Add(new Move(CurrentX - 1, CurrentY + 2));
                }
            }
            if (CurrentX < 7 && CurrentY > 1)
            {
                if (Board[CurrentX + 1, CurrentY - 2]._ImAlive == false || Board[CurrentX + 1, CurrentY - 2]._ImBlack != BlacksTurn)  //Check move x+1, y-2
                {
                    this.AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY - 2));
                }
            }
            if (CurrentX > 0 && CurrentY > 1)
            {
                if (Board[CurrentX - 1, CurrentY - 2]._ImAlive == false || Board[CurrentX - 1, CurrentY - 2]._ImBlack != BlacksTurn) //Check move x-1, y-2
                {
                    this.AvilibleMoves.Add(new Move(CurrentX - 1, CurrentY - 2));
                }
            }
        }
    }
}
