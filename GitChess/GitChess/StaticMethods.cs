using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChess
{
   public static class StaticMethods
    {
        public static string ReturnFrame(int y)
        {
            y += 1;
            string ABC = "   ";
            if (y == 1) { ABC = " B "; }
            if (y == 2) { ABC = " C "; }
            if (y == 3) { ABC = " D "; }
            if (y == 4) { ABC = " E "; }
            if (y == 5) { ABC = " F "; }
            if (y == 6) { ABC = " G "; }
            if (y == 7) { ABC = " H "; }

            return ABC;
        }

        internal static bool HowIsEnemy(bool BlacksTurn)
        {
            if (BlacksTurn) {return false; } else {return true; } // Check wath color your enemy is
        }
        
        //public static void CleanMoves(Piece[,] Board,List<Moves> PossibleMoves)
        //{
        //    for (int y = 0; y < 8; y++)
        //    {
        //        for (int x = 0; x < 8; x++)
        //        {
        //            Board[x, y].PossibleMoves.RemoveRange(0, PossibleMoves.Count - 1);
        //        }
        //    }

        //}
    }
}
  
