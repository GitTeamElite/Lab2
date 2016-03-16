﻿using System;
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
        public override void CheckMove(bool BlacksTurn, Piece[,] Board, int CurrentX, int CurrentY  )
        {
           


            if (Board[CurrentY, CurrentX ]._ImBlack == true && CurrentY < 7) /// Black Pieces
            {
              
                if (CurrentY < 7)
                {
                    if (Board[CurrentY + 1, CurrentX + 1 ]._ImBlack != BlacksTurn && Board[CurrentY + 1, CurrentX + 1 ]._ImAlive == true) //Takes a enmey 
                    {
                        this.AvilibleMoves.Add(new Move(CurrentY + 1, CurrentX + 1 ));
                    }
                }
                if (CurrentY > 0)
                {
                    if (Board[CurrentY + 1, CurrentX - 1 ]._ImBlack != BlacksTurn && Board[CurrentY + 1, CurrentX - 1 ]._ImAlive == true)   //Takes a enmey 
                    {
                        this.AvilibleMoves.Add(new Move(CurrentY + 1, CurrentX - 1 ));
                    }
                }
                if (Board[CurrentY + 1, CurrentX ]._ImAlive == false)                  // just moves forward
                    this.AvilibleMoves.Add(new Move(CurrentY + 1, CurrentX ));
            }

            if (Board[CurrentY , CurrentX]._ImBlack == false && CurrentY > 0)  // White pieces
            {
                
                if (CurrentX < 7)
                {
                    if (Board[CurrentY - 1, CurrentX + 1 ]._ImBlack != BlacksTurn && Board[CurrentY - 1, CurrentX + 1 ]._ImAlive == true) //Takes a enmey 
                    {
                        this.AvilibleMoves.Add(new Move(CurrentY - 1, CurrentX + 1 ));
                    }
                }
                if (CurrentX > 0)
                {
                    if (Board[CurrentY - 1, CurrentX - 1 ]._ImBlack != BlacksTurn && Board[CurrentY - 1, CurrentX - 1 ]._ImAlive == true)   //Takes a enmey 
                    {
                        this.AvilibleMoves.Add(new Move(CurrentY - 1, CurrentX - 1 ));
                    }
                }
                if (Board[CurrentY - 1, CurrentX ]._ImAlive == false)                  // just moves forward
                    this.AvilibleMoves.Add(new Move(CurrentY - 1, CurrentX ));
            }


            if (BlacksTurn && CurrentY == 1 && Board[CurrentY + 1, CurrentX ]._ImAlive == false && Board[CurrentY + 2, CurrentX ]._ImAlive == false)  // Black can move 2 step from start poss
            {
                this.AvilibleMoves.Add(new Move(CurrentY + 2, CurrentX ));
            }
            if (!BlacksTurn && CurrentY == 6 && Board[CurrentY - 1, CurrentX ]._ImAlive == false && Board[CurrentY - 2, CurrentX ]._ImAlive == false) //  White can move 2 step from start poss
            {
                this.AvilibleMoves.Add(new Move(CurrentY - 2, CurrentX ));
            }



        }

    }
}
