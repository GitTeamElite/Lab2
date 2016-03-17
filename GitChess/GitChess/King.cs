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
            AllKingMoves(BlacksTurn, Board, CurrentX, CurrentY);
        }
        //    if (CUrrentX < 7)
        //    {
        //        if (Board[CurrentY, CUrrentX + 1]._ImAlive == false) //Check move x+1, y1 ----
        //        { AvilibleMoves.Add(new Move(CUrrentX + 1, CurrentY)); }
        //    }
        //    if (CurrentY < 7)
        //    {
        //        if (Board[CurrentY + 1, CUrrentX]._ImAlive == false) //Check move x+1, y
        //        { AvilibleMoves.Add(new Move(CUrrentX, CurrentY + 1)); }
        //    }
        //    if (CurrentY > 0)
        //    {
        //        if (Board[CurrentY - 1, CUrrentX]._ImAlive == false) //Check move x-1, y
        //        { AvilibleMoves.Add(new Move(CUrrentX, CurrentY - 1)); }
        //    }
        //    if (CUrrentX > 0)
        //    {
        //        if (Board[CurrentY, CUrrentX - 1]._ImAlive == false)   //Check move x, y-1
        //        { AvilibleMoves.Add(new Move(CUrrentX - 1, CurrentY)); }
        //    }
        //    if (CurrentY > 0 && CUrrentX > 0)
        //    {
        //        if (Board[CurrentY - 1, CUrrentX - 1]._ImAlive == false)//Check move x-1, y-1
        //        { AvilibleMoves.Add(new Move(CUrrentX - 1, CurrentY - 1)); }
        //    }
        //    if (CurrentY < 7 && CUrrentX > 0)
        //    {
        //        if (Board[CurrentY + 1, CUrrentX - 1]._ImAlive == false)//Check move x+1, y-1
        //        {
        //            AvilibleMoves.Add(new Move(CUrrentX - 1, CurrentY + 1));
        //        }
        //    }
        //    if (CurrentY > 0 && CUrrentX < 7)
        //    {
        //        if (Board[CurrentY - 1, CUrrentX + 1]._ImAlive == false) //Check move x-1, y+1 
        //        { AvilibleMoves.Add(new Move(CUrrentX + 1, CurrentY - 1)); }
        //    }
        //    if (CurrentY < 7 && CUrrentX < 7)
        //    {
        //        if (Board[CurrentY + 1, CUrrentX + 1]._ImAlive == false) //Check move x+1, y+1 
        //        { AvilibleMoves.Add(new Move(CUrrentX + 1, CurrentY + 1)); }
        //    }
        //}
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
