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
        public override void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY)
        {



            if (Board[CurrentY, CurrentX]._ImBlack == true && CurrentY < 7) /// Black Pieces
            {

                if (CurrentX < 7)
                {
                    if (Board[CurrentX + 1, CurrentY + 1]._ImBlack == false && Board[CurrentX + 1, CurrentY + 1]._ImAlive == true) //Takes a enmey 
                    {
                        this.AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY + 1));
                    }

                    if (CurrentX > 0)
                    {
                        if (Board[CurrentX + 1, CurrentY - 1]._ImBlack == false && Board[CurrentX - 1, CurrentY + 1]._ImAlive == true)   //Takes a enmey 
                        {
                            this.AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY - 1));
                        }
                    }
                    if (Board[CurrentX + 1, CurrentY]._ImAlive == false)                  // just moves forward
                        this.AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY));
                }
            }

            if (Board[CurrentX, CurrentY]._ImBlack == false && CurrentY > 0)  // White pieces
            {

                if (CurrentX < 7)
                {
                    if (Board[CurrentX + 1, CurrentY - 1]._ImBlack == true && Board[CurrentX + 1, CurrentY - 1]._ImAlive == true) //Takes a enmey 
                    {
                        this.AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY - 1));
                    }
                }
                if (CurrentX > 0)
                {
                    if (Board[CurrentX - 1, CurrentY - 1]._ImBlack == true && Board[CurrentX - 1, CurrentY - 1]._ImAlive == true)   //Takes a enmey 
                    {
                        this.AvilibleMoves.Add(new Move(CurrentX - 1, CurrentY - 1));
                    }
                }
                if (Board[CurrentX, CurrentY - 1]._ImAlive == false)                  // just moves forward
                    this.AvilibleMoves.Add(new Move(CurrentX, CurrentY - 1));
            }


            if (Board[CurrentX, CurrentY]._ImBlack == true && CurrentY == 1 && Board[CurrentX, CurrentY + 1]._ImAlive == false && Board[CurrentX, CurrentY + 2]._ImAlive == false)  // Black can move 2 step from start poss
            {
                this.AvilibleMoves.Add(new Move(CurrentX, CurrentY + 2));
            }
            if (Board[CurrentX, CurrentY]._ImBlack == false && CurrentY == 6 && Board[CurrentX, CurrentY - 1]._ImAlive == false && Board[CurrentX, CurrentY - 2]._ImAlive == false) //  White can move 2 step from start poss
            {
                this.AvilibleMoves.Add(new Move(CurrentX, CurrentY - 2));
            }







        }
    }
}
