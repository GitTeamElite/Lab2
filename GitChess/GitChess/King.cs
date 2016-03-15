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
        }
        public void  CheckMove(bool BlacksTurn, bool BlackIsEnemy, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY) // Checking base move rules         
        { 
            if (Board[CurrentX + 1, CurrentY]._ImAlive == false || Board[CurrentX + 1, CurrentY]._ImBlack != BlackIsEnemy) //Check move x+1, y
            { AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY));   }    

            if (Board[CurrentX - 1, CurrentY]._ImAlive == false || Board[CurrentX - 1, CurrentY]._ImBlack != BlackIsEnemy) //Check move x-1, y
            { AvilibleMoves.Add(new Move(CurrentX - 1, CurrentY));  }  

            if (Board[CurrentX, CurrentY + 1]._ImAlive == false || Board[CurrentX, CurrentY + 1]._ImBlack != BlackIsEnemy) //Check move x, y+1
            { AvilibleMoves.Add(new Move(CurrentX, CurrentY + 1)); }  

            if (Board[CurrentX, CurrentY - 1]._ImAlive == false|| Board[CurrentX, CurrentY - 1]._ImBlack != BlackIsEnemy)   //Check move x, y-1
            { AvilibleMoves.Add(new Move(CurrentX, CurrentY - 1));  }

            if (Board[CurrentX + 1, CurrentY + 1]._ImAlive == false|| Board[CurrentX + 1, CurrentY + 1]._ImBlack!=BlackIsEnemy) //Check move x+1, y+1
            { AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY + 1));  }  

            if (Board[CurrentX - 1, CurrentY - 1]._ImAlive == false|| Board[CurrentX - 1, CurrentY - 1]._ImBlack!=BlackIsEnemy)//Check move x-1, y-1
            { AvilibleMoves.Add(new Move(CurrentX - 1, CurrentY - 1));  }  

            if (Board[CurrentX + 1, CurrentY - 1]._ImAlive == false|| Board[CurrentX + 1, CurrentY - 1]._ImBlack!=BlackIsEnemy)//Check move x+1, y-1
            { AvilibleMoves.Add(new Move(CurrentX + 1, CurrentY - 1));  }   

            if (Board[CurrentX - 1, CurrentY + 1]._ImAlive == false|| Board[CurrentX - 1, CurrentY + 1]._ImBlack!=BlackIsEnemy) //Check move x-1, y+1
            { AvilibleMoves.Add(new Move(CurrentX - 1, CurrentY + 1));  }    
        }

    }
}
