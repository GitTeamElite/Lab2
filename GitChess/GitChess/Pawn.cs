using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Pawn : Piece
    {
        public Pawn(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " P ";
            this.Points = 1;
        }
        public override bool CheckMove(bool BlacksTurn,bool BlackIsEnemy,Piece[,] Board, int CurrentX, int CurrentY,int MovingX,int MovingY)
        {
            if (!base.CheckMove(BlacksTurn, BlackIsEnemy, Board, CurrentX, CurrentY,MovingX,MovingY)) { return false; } // Checking base rules

         
            int MyMove = 0;

            if (BlacksTurn == Board[CurrentX, CurrentY]._ImBlack)  // if blacks turn Pawn can move +1, white -1
                if (BlacksTurn) { MyMove = 1; }
                else { MyMove = -1; }


            if (Board[CurrentX + 1, CurrentY + MyMove]._ImBlack == BlackIsEnemy && Board[CurrentX + 1, CurrentY + MyMove]._ImAlive == true || //\___Takes a enmey 
                Board[CurrentX - 1, CurrentY + MyMove]._ImBlack == BlackIsEnemy && Board[CurrentX - 1, CurrentY + MyMove]._ImAlive == true)   ///
            { return true; }

            if (Board[CurrentX, CurrentY + MyMove]._ImAlive == false) { return true; } // just moves forward
            if (CurrentY == 3 && BlacksTurn && Board[CurrentX, CurrentY]._ImAlive == false) { return true; } //\____ moves forward 2 steps from start position
            if (CurrentY == 4 && !BlacksTurn && Board[CurrentX, CurrentY]._ImAlive == false) { return true; } // 



            return false;

        }

    }
}
