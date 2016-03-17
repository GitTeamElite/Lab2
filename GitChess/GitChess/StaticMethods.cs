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
            if (y == 1) { ABC = " y2 "; }
            if (y == 2) { ABC = " y3 "; }
            if (y == 3) { ABC = " y4 "; }
            if (y == 4) { ABC = " y5 "; }
            if (y == 5) { ABC = " y6 "; }
            if (y == 6) { ABC = " y7 "; }
            if (y == 7) { ABC = " y8 "; }

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
        public static int TranslateLetters(string letter)
        {
            if(letter == "1") { return 0; }
            if (letter == "2") { return 1; }
            if (letter == "3") { return 2; }
            if (letter == "4") { return 3; }
            if (letter == "5") { return 4; }
            if (letter == "6") { return 5; }
            if (letter == "7") { return 6; }
            if (letter == "8") { return 7; }

            else return -1;
        }
    
    }
}
  
