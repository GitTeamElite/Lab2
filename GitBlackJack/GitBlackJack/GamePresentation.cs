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
        public static void LOGG()
        {


            Console.WriteLine(".------..-------..------..------..------.     .-------..------..------..------.");
            Console.WriteLine("| B    || L     || A    || C    || K    |     | J     || A    || C    || K    |");
            Console.WriteLine("|  ()  ||  /\\   ||  \\/  ||  /\\  || /\\   | --- |  ()   ||  \\/  ||  /\\  ||  /\\  |");
            Console.WriteLine("| ()() || (__)  ||  \\/  ||  \\/  || \\/   | --- | ()()  ||  \\/  ||  \\/  ||  \\/  |");
            Console.WriteLine("|     B||     L ||    A ||    C ||    K |     |     J ||    A ||     C||    K |");
            Console.WriteLine(" `-----' `------'`------' `-----' `-----'      `------' `-----' `-----' `-----'");



        }
        public static void PrintGame(List<Card> Player, List<Card> Dealer, int bet, int PlayerBalance)
        {
            Console.Clear();
            LOGG();
            Console.WriteLine("        D e a l e r   H a n d");
            GamePresentation.PrintCardHand(Dealer);
            GamePresentation.PrintTotalValue(Dealer);
            Console.WriteLine("\n");
            Console.WriteLine("        P l a y e r   H a n d");
            Console.WriteLine("        $$ " + PlayerBalance + " $$ Bet :" + bet + " $$");
            GamePresentation.PrintCardHand(Player);
            GamePresentation.PrintTotalValue(Player);
            Console.WriteLine("\n---------------------------------------");
        }
    }
}
