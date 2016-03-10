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
    }
}
