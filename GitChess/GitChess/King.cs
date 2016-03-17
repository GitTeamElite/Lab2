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
            this._ImAlive = true;
        }
        public override void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentY, int CurrentX) // Checking base move rules         
        {
            // AllKingMoves(BlacksTurn, Board, CurrentX, CurrentY);
            // }
            if (CurrentX < 7)
            {
                if (Board[CurrentY, CurrentX + 1]._ImAlive == false || Board[CurrentY, CurrentX + 1]._ImBlack != BlacksTurn) //Check move x+1, y1 ----
                { AvilibleMoves.Add(new Move( CurrentY,CurrentX + 1)); }
            }
            if (CurrentY < 7)
            {
                if (Board[CurrentY + 1, CurrentX]._ImAlive == false || Board[CurrentY, CurrentX + 1]._ImBlack != BlacksTurn)) //Check move x+1, y
                { AvilibleMoves.Add(new Move( CurrentY + 1,CurrentX)); }
            }
            if (CurrentY > 0)
            {
                if (Board[CurrentY - 1, CurrentX]._ImAlive == false || Board[CurrentY, CurrentX + 1]._ImBlack != BlacksTurn)) //Check move x-1, y
                { AvilibleMoves.Add(new Move( CurrentY - 1,CurrentX)); }
            }
            if (CurrentX > 0)
            {
                if (Board[CurrentY, CurrentX - 1]._ImAlive == false || Board[CurrentY, CurrentX + 1]._ImBlack != BlacksTurn))   //Check move x, y-1
                { AvilibleMoves.Add(new Move(CurrentY,CurrentX - 1)); }
            }
            if (CurrentY > 0 && CurrentX > 0)
            {
                if (Board[CurrentY - 1, CurrentX - 1]._ImAlive == false || Board[CurrentY, CurrentX + 1]._ImBlack != BlacksTurn))//Check move x-1, y-1
                { AvilibleMoves.Add(new Move( CurrentY - 1,CurrentX - 1)); }
            }
            if (CurrentY < 7 && CurrentX > 0)
            {
                if (Board[CurrentY + 1, CurrentX - 1]._ImAlive == false || Board[CurrentY, CurrentX + 1]._ImBlack != BlacksTurn))//Check move x+1, y-1
                {
                    AvilibleMoves.Add(new Move( CurrentY + 1,CurrentX - 1));
                }
            }
            if (CurrentY > 0 && CurrentX < 7)
            {
                if (Board[CurrentY - 1, CurrentX + 1]._ImAlive == false || Board[CurrentY, CurrentX + 1]._ImBlack != BlacksTurn)) //Check move x-1, y+1 
                { AvilibleMoves.Add(new Move( CurrentY - 1,CurrentX + 1)); }
            }
            if (CurrentY < 7 && CurrentX < 7)
            {
                if (Board[CurrentY + 1, CurrentX + 1]._ImAlive == false || Board[CurrentY, CurrentX + 1]._ImBlack != BlacksTurn)) //Check move x+1, y+1 
                { AvilibleMoves.Add(new Move( CurrentY + 1,CurrentX + 1)); }
            }
        }
        public void kingMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY, int x, int y)
        {
            if (CurrentX + x < 0 || CurrentX + x > 7 || CurrentY + y < 0 || CurrentY + y > 7) return;
            {
                if (Board[CurrentX + x, CurrentY + y]._ImAlive == false) //Check move x+1, y+1 
                { AvilibleMoves.Add(new Move(CurrentX + x, CurrentY + y)); }
            }
        }

        public void AllKingMoves(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {
            kingMove(BlacksTurn, Board, CurrentX, CurrentY, 1, 0);
            kingMove(BlacksTurn, Board, CurrentX, CurrentY, 0, 1);
            kingMove(BlacksTurn, Board, CurrentX, CurrentY, 1, 1);
            kingMove(BlacksTurn, Board, CurrentX, CurrentY, -1, 1);
            kingMove(BlacksTurn, Board, CurrentX, CurrentY, 1, -1);
            kingMove(BlacksTurn, Board, CurrentX, CurrentY, -1, 0);
            kingMove(BlacksTurn, Board, CurrentX, CurrentY, 0, -1);
            kingMove(BlacksTurn, Board, CurrentX, CurrentY, -1, -1);
        }
    }
}
