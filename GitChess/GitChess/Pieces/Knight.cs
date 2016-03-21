using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Knight : Piece // Done
    {
        public Knight(bool _ImBlack) : base(_ImBlack) //ss
        {
            this._MyVisualLook = " k ";
            this._ImAlive = true;
            this.Points = 5;
        }
        public override void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentY, int CurrentX)
        {
            
            if (CurrentX < 6 && CurrentY < 7)
            {
                if (Board[CurrentY + 1, CurrentX + 2 ]._ImAlive == false || Board[CurrentY + 1, CurrentX + 2 ]._ImBlack != Board[CurrentY, CurrentX]._ImBlack)  //Check move x+2, y+1 

                {
                   AddMoveToList(CurrentY, CurrentX,CurrentY + 1,CurrentX + 2, Board, BlacksTurn);
                }
            }

            if (CurrentX < 6 && CurrentY > 0)
            {
                if (Board[CurrentY - 1, CurrentX + 2 ]._ImAlive == false || Board[CurrentY - 1, CurrentX + 2]._ImBlack != Board[CurrentY, CurrentX]._ImBlack)  //Check move x+2, y-1
                {
                   AddMoveToList(CurrentY, CurrentX, CurrentY - 1,CurrentX + 2, Board, BlacksTurn);
                }
            }
            if (CurrentX > 1 && CurrentY < 7)
            {
                if (Board[CurrentY + 1, CurrentX - 2 ]._ImAlive == false || Board[CurrentY + 1, CurrentX - 2 ]._ImBlack != Board[CurrentY, CurrentX]._ImBlack)  //Check CurrentX  &&  CurrentY x-2, y+1
                {
                   AddMoveToList( CurrentY, CurrentX,CurrentY + 1,CurrentX - 2, Board, BlacksTurn);
                }
            }
            if (CurrentX > 1 && CurrentY > 0)
            {
                if (Board[CurrentY - 1, CurrentX - 2 ]._ImAlive == false || Board[CurrentY - 1, CurrentX - 2 ]._ImBlack != Board[CurrentY, CurrentX]._ImBlack)  //Check move x-2, y-1
                {
                   AddMoveToList(CurrentY, CurrentX, CurrentY - 1,CurrentX - 2, Board, BlacksTurn);
                }
            }
            if (CurrentX < 7 && CurrentY < 6)
            {
                if (Board[CurrentY + 2, CurrentX + 1 ]._ImAlive == false || Board[CurrentY + 2, CurrentX + 1 ]._ImBlack != Board[CurrentY, CurrentX]._ImBlack)   //Check move x+1, y+2
                {
                   AddMoveToList(CurrentY,CurrentX,CurrentY + 2, CurrentX + 1, Board, BlacksTurn);
                }
            }
            if (CurrentX > 0 && CurrentY < 6)
            {
                if (Board[CurrentY + 2 , CurrentX - 1]._ImAlive == false || Board[CurrentY + 2, CurrentX - 1 ]._ImBlack != Board[CurrentY, CurrentX]._ImBlack)  //Check move x-1, y+2
                {
                  AddMoveToList(CurrentY, CurrentX, CurrentY + 2,CurrentX - 1, Board, BlacksTurn);
                }
            }
            if (CurrentX < 7 && CurrentY > 1)
            {
                if (Board[CurrentY - 2, CurrentX + 1]._ImAlive == false || Board[CurrentY - 2, CurrentX + 1]._ImBlack != Board[CurrentY,CurrentX]._ImBlack)  //Check move x+1, y-2
                {
                   AddMoveToList(CurrentY, CurrentX, CurrentY - 2,CurrentX + 1, Board, BlacksTurn);
                }
            }
            if (CurrentX > 0 && CurrentY > 1)
            {
                if (Board[CurrentY - 2, CurrentX - 1 ]._ImAlive == false || Board[CurrentY - 2, CurrentX - 1 ]._ImBlack != Board[CurrentY, CurrentX]._ImBlack) //Check move x-1, y-2
                {
                   AddMoveToList(CurrentY, CurrentX, CurrentY - 2,CurrentX - 1, Board, BlacksTurn);
                }
            }

        }
       
      
    }
}
