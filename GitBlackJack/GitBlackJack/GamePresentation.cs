using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    static class GamePresentation
    {
        /// <summary>
        /// Prints The cars atributes in one list
        /// </summary>
        /// <param name="CardList"></param>
        public static void PrintCardHand(List<Card> CardList)
        {
            Console.WriteLine("---------------------------------------");
            int CardNr = 1;
            foreach (var item in CardList)
            {
                if (item.Type == "Ace") { Console.Write("Card nr:" + CardNr + "    " + item._Color + " of " + item.Type + " - " + item._Value + item._AceValue + "\n"); }
                else { Console.Write("Card nr:" + CardNr + "    " + item._Color + " of " + item.Type + " - " + item._Value + "\n"); }

                CardNr++;
            }
        }
        /// <summary>
        /// Prints totalvalue on cards of one list
        /// </summary>
        /// <param name="CardList"></param>
        public static void PrintTotalValue(List<Card> CardList)
        {

            int TotalValue = StaticMethods.CountValue(CardList);

            Console.WriteLine("---------------------------------------");

            Console.Write("Total value of the cards: " + TotalValue);

        }
        /// <summary>
        /// Prints BLACK JACK loggotype
        /// </summary>
        public static void LOGG()
        {


            Console.WriteLine(".------..-------..------..------..------.     .-------..------..------..------.");
            Console.WriteLine("| B    || L     || A    || C    || K    |     | J     || A    || C    || K    |");
            Console.WriteLine("|  ()  ||  /\\   ||  \\/  ||  /\\  || /\\   | --- |  ()   ||  \\/  ||  /\\  ||  /\\  |");
            Console.WriteLine("| ()() || (__)  ||  \\/  ||  \\/  || \\/   | --- | ()()  ||  \\/  ||  \\/  ||  \\/  |");
            Console.WriteLine("|     B||     L ||    A ||    C ||    K |     |     J ||    A ||     C||    K |");
            Console.WriteLine(" `-----' `------'`------' `-----' `-----'      `------' `-----' `-----' `-----'");



        }
        /// <summary>
        /// Prints both hands
        /// </summary>
        /// <param name="Player"></param>
        /// <param name="Dealer"></param>
        /// <param name="bet"></param>
        /// <param name="PlayerBalance"></param>
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
        /// <summary>
        /// Prints a list with all cards
        /// </summary>
        /// <param name="cardList"></param>
        public static void PrintADeck(List<Card> cardList)
        {
            int x = 1;
         
            foreach (var item in cardList)
            {
                Console.Write($"Card:{x} - {item._Value} - {item.Type} - {item._Color}");              
                Console.WriteLine("");
                x++;
            }
        }
        public static void ControlCheck(Dealer dealer,Deck deck)
        {
            Console.WriteLine("write \"check\" if you wanna see the decks. . . ");
          string check = Console.ReadLine();
            if (check == "check")
            {

                Console.WriteLine("Sorted deck");
                GamePresentation.PrintADeck(deck.GiveDeck());
                Console.WriteLine("\n\nDealer Deck");
                GamePresentation.PrintADeck(dealer.GiveActiveDeck());
                Console.ReadKey();  
            }      
            Console.Clear();
        }
        public static void EndMsg(bool win)
        {
            if (win) { Console.WriteLine("Player WIN!!!"); }
            else { Console.WriteLine("Dealer WIN!!!"); }
            Console.ReadKey();
            Console.Clear();
        }
        public static void GameOver()
        {
            Console.WriteLine("You are out of cash. . . GAMEOVER casino WIN!!");
            Console.ReadKey();
            Console.Clear();
        }
    
    }
}
