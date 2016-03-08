using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    class StaticMethods
    {
        public static string ReturnType(int y)
        {
            string Ytype = "";

            if (y == 0) { Ytype = "Heart"; }
            if (y == 1) { Ytype = "Dimond"; }
            if (y == 2) { Ytype = "Spade"; }
            if (y == 3) { Ytype = "Clobe"; }

            return Ytype;
        }
        public static int CountValue(List<Card> CardList)
        {
            int totalValue = 0;
            foreach (var item in CardList)
            {
                totalValue += item._Value;
            }
            return totalValue;
        }
    }
}
