using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class King : Piece
    {
        public King(bool _ImBlack) : base(_ImBlack)
        {
            this._MyVisualLook = " K ";
        }
        public override bool CheckMove(bool BlacksTurn,bool BlackIsEnemy, Piece[,] Board, int CurrentX, int CurrentY, int MovingX, int MovingY) // Checking base move rules         
        {
            // 1 move on all spots around

            if (CurrentX == MovingX + 1 && CurrentY == MovingY)
            {
                if (Board[MovingX, MovingY]._ImAlive == false)
                { // Lägg till att han kan ta moståndare också!       } }

                }
            }

            return true;
        }
    }
}
