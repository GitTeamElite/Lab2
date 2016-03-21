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
            this.Points = 10;
        }
        public override void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentY, int CurrentX) // Checking base move rules         
        {
            AllKingMoves(BlacksTurn, Board, CurrentX, CurrentY);
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


        public void kingMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY, int x, int y)
        {
            if (CurrentX + x < 0 || CurrentX + x > 7 || CurrentY + y < 0 || CurrentY + y > 7) return;
            {
                if (Board[CurrentY + y, CurrentX + x]._ImAlive == false || Board[CurrentY + y, CurrentX + x]._ImBlack != BlacksTurn) //Check move x+1, y+1 
                {
                    AddMoveToList(CurrentY, CurrentX, CurrentY + y, CurrentX + x, Board, BlacksTurn);
                }
            }
        }
      
     
    }

}
