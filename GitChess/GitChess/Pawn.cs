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
        public void MovePawn(bool BlacksTurn,Piece[,] Board,int x,int y,Piece piece)
        {
            int move = 0;
            int modifyedMove = 0;
            if (BlacksTurn) { move = 1; }
            else  { move = -1; }

            if (Board[x,y+move]._ImAlive == false)
            {
                modifyedMove = y + move;
                Board[x, y].AddMoveToMoveList(x,modifyedMove);
            }
            
        }
        
    }
}
