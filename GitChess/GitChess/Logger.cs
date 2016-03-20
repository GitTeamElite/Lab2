using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
    class Logger
    {
        string WhitePiecesDied = "";
        string BlackPiecesDied = "";

        public void LoggDeaths(bool BlacksTurn,Piece[,] Board,int y , int x)
        {
            if (BlacksTurn)
            {
                WhitePiecesDied += Board[y, x]._MyVisualLook;
            }
            else
            {
                BlackPiecesDied += Board[y, x]._MyVisualLook;
            }
        }
    }
}
