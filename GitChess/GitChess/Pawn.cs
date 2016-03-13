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
        }
        public override bool CheckMove(bool BlacksTurn,Piece[,] Board,int x, int y )
        {
       if (base.CheckMove(BlacksTurn,Board,x,y)) { return false; }

            bool BlackIsEnemy; if (BlacksTurn) { BlackIsEnemy = false; } else { BlackIsEnemy = true; }
            int MyMove = 0;
         
            if (BlacksTurn == Board[x,y]._ImBlack)  if(BlacksTurn) { MyMove = 1; } else { MyMove = -1; }
            else { if (BlacksTurn) { MyMove = -1; } else { MyMove = 1; } }



            if (Board[x+1,y+MyMove]._ImBlack == BlackIsEnemy && Board[x + 1, y + MyMove]._ImAlive == true ||
                Board[x - 1, y + MyMove]._ImBlack == BlackIsEnemy && Board[x - 1, y + MyMove]._ImAlive == true)
            { return true; }
            if (Board[x,y+MyMove]._ImAlive == false) { return true;   }

            return false;
            
        }
        
    }
}
