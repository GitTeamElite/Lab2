using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
   static class GamePresentation
    {
        public static void PrintCardHand(List<Card> CardList)
        {
            foreach (var item in CardList)
            {
                Console.WriteLine("Card-"+ item._Value+" "+item._Type);
            }
        }
        public static void PrintTotalValue(List<Card> CardList)
        {
            int TotalValue = StaticMethods.CountValue(CardList);
            Console.WriteLine("Total value of the cards: "+TotalValue);
        }
    }
}
