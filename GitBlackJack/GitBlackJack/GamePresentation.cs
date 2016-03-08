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

            /*
            Console.WriteLine("BBBBBBBBB     LLL               AAAA             CCCCC    KKK        JJJ    AAA    CCC    KKK ");
            Console.WriteLine("BBB   BBBB    LLL              AAAAAA          CCC    C   KKK        JJJ    AAA    CCC    KKK ");
            Console.WriteLine("BBB BBBBB     LLL             AAA  AAA       CCC          KKK        JJJ    AAA    CCC    KKK ");
            Console.WriteLine("BBBBBBBB      LLL            AAA    AAA     CC            KKK        JJJ    AAA    CCC    KKK ");
            Console.WriteLine("BBB BBBBB     LLL           AAAAAAAAAAAA    CC            KKK        JJJ    AAA    CCC    KKK ");
            Console.WriteLine("BBB   BBBB    LLL          AAA        AAA    CCC          KKK        JJJ    AAA    CCC    KKK ");
            Console.WriteLine("BBB BBBBB     LLL         AAA          AAA     CCC        KKK        JJJ    AAA    CCC    KKK ");
            Console.WriteLine("BBBBBBBBB     LLLLLLLLL  AAA            AAA       CCC     KKK        JJJ    AAA    CCC    KKK ");
            */

            Console.WriteLine(".------..-------..------..------..------.     .-------..------..------..------.");
            Console.WriteLine("| B    || L     || A    || C    || K    |     | J     || A    || C    || K    |");
            Console.WriteLine("|  ()  ||  /\\   ||  \\/  ||  /\\  || /\\   | --- |  ()   ||  \\/  ||  /\\  ||  /\\  |");
            Console.WriteLine("| ()() || (__)  ||  \\/  ||  \\/  || \\/   | --- | ()()  ||  \\/  ||  \\/  ||  \\/  |");
            Console.WriteLine("|     B||     L ||    A ||    C ||    K |     |     J ||    A ||     C||    K |");
            Console.WriteLine(" `-----' `------'`------' `-----' `-----'      `------' `-----' `-----' `-----'");



        }
    }
}
