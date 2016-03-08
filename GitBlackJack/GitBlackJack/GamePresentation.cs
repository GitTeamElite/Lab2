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
            Console.WriteLine("---------------------------------------");
            int CardNr = 1;
            foreach (var item in CardList)
            {
                Console.WriteLine("Card nr:"+CardNr+"    "+ item._Color+" of "+item.Type+" - "+item._Value);
                CardNr++;
            }
        }
        public static void PrintTotalValue(List<Card> CardList)
        {
            Console.WriteLine("---------------------------------------");
            int TotalValue = StaticMethods.CountValue(CardList);
            Console.WriteLine("Total value of the cards: "+TotalValue);
        }


    }
}
