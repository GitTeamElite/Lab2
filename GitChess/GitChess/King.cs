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
        public override void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentY, int CUrrentX) // Checking base move rules         
        {
            if (CUrrentX < 7)
            {
                if (Board[CurrentY, CUrrentX + 1]._ImAlive == false) //Check move x+1, y1 ----
                { AvilibleMoves.Add(new Move(CurrentY, CUrrentX + 1)); }
            }
            if (CurrentY < 7)
            {
                if (Board[CurrentY + 1, CUrrentX]._ImAlive == false ) //Check move x+1, y
                { AvilibleMoves.Add(new Move(CurrentY + 1, CUrrentX)); }
            }
            if (CurrentY > 0)
            {
                if (Board[CurrentY - 1, CUrrentX]._ImAlive == false ) //Check move x-1, y
                { AvilibleMoves.Add(new Move(CurrentY - 1, CUrrentX)); }
            }          
            if (CUrrentX > 0)
            {
                if (Board[CurrentY, CUrrentX - 1]._ImAlive == false)   //Check move x, y-1
                { AvilibleMoves.Add(new Move(CurrentY, CUrrentX - 1)); }
            }
            if (CurrentY > 0 && CUrrentX > 0)
            {
                if (Board[CurrentY - 1, CUrrentX - 1]._ImAlive == false)//Check move x-1, y-1
                { AvilibleMoves.Add(new Move(CurrentY - 1, CUrrentX - 1)); }
            }
            if (CurrentY < 7 && CUrrentX > 0)
            {
                if (Board[CurrentY + 1, CUrrentX - 1]._ImAlive == false )//Check move x+1, y-1
                {
                    AvilibleMoves.Add(new Move(CurrentY + 1, CUrrentX - 1));
                }          
            }
            if (CurrentY > 0 && CUrrentX < 7)
            {
                if (Board[CurrentY - 1, CUrrentX + 1]._ImAlive == false ) //Check move x-1, y+1 
                { AvilibleMoves.Add(new Move(CurrentY - 1, CUrrentX + 1)); }
            }
            if (CurrentY < 7 && CUrrentX < 7)
            {
                if (Board[CurrentY + 1, CUrrentX + 1]._ImAlive == false) //Check move x+1, y+1 
                { AvilibleMoves.Add(new Move(CurrentY + 1, CUrrentX + 1)); }
            }
        }

    }
}
