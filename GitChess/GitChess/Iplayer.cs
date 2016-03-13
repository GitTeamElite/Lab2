using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    interface Iplayer
    {

        List<Piece> IplayPieceList();
        List<Move> IplayMoveList();
            

        void MovePiece();
        void CheckThretenPieces();
        void CheckAvilibleMoves();
    }
}
