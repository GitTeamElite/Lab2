using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Pawn : Piece // Done
    {
        public Pawn(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " P ";
            this.Points = 1;
            this._ImAlive = true;
        }
        public override void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentY, int CurrentX)
        {

            int nr = 0;
            int transform = 0;
            if (Board[CurrentY,CurrentX]._ImBlack) { nr = 1;transform = 7; }
            else { nr = -1;transform = 0; }
           

            if (CurrentY + nr < 8 && CurrentY + nr > -1 && CurrentX + nr < 8 && CurrentX + nr > 1)
            {
                if (CurrentX + 1 < 8)
                {
                    if (Board[CurrentY + nr, CurrentX + 1]._ImBlack != BlacksTurn && Board[CurrentY + nr, CurrentX + 1]._ImAlive == true) //Takes a enmey 
                    {
                        AddMoveToList(CurrentY, CurrentX, CurrentY + nr, CurrentX + 1, Board, BlacksTurn);
                    }
                }
                if (CurrentX - 1 > 0)
                {
                    if (Board[CurrentY + nr, CurrentX - 1]._ImBlack != BlacksTurn && Board[CurrentY + nr, CurrentX - 1]._ImAlive == true)   //Takes a enmey 
                    {
                        AddMoveToList(CurrentY, CurrentX, CurrentY + nr, CurrentX - 1, Board, BlacksTurn);
                    }
                }
                
            }
            if (CurrentY + nr > -1 && CurrentY + nr < 8 && Board[CurrentY + nr, CurrentX]._ImAlive == false) // just moves forward
            {
                if (CurrentY == transform) { }
                AddMoveToList(CurrentY, CurrentX, CurrentY + nr, CurrentX, Board, BlacksTurn);
            }


            if (Board[CurrentY, CurrentX]._ImBlack == true && CurrentY == 1 && 
                Board[CurrentY + 1, CurrentX]._ImAlive == false && Board[CurrentY + 2, CurrentX]._ImAlive == false)  // Black can move 2 step from start poss
            {
               AddMoveToList(CurrentY, CurrentX, CurrentY + 2, CurrentX, Board, BlacksTurn);
            }
            if (Board[CurrentY, CurrentX]._ImBlack == false && CurrentY == 6 &&
                Board[CurrentY - 1, CurrentX]._ImAlive == false && Board[CurrentY - 2, CurrentX]._ImAlive == false) //  White can move 2 step from start poss
            {
             AddMoveToList(CurrentY, CurrentX, CurrentY - 2, CurrentX, Board, BlacksTurn);
            }
        }
       
    }
}
