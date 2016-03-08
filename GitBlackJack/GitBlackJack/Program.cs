using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            Dealer dealer = new Dealer(1000);
            Deck deck = new Deck();
            Player player = new Player(100);


            while (!quit)
            {

                var x = 0;
                while (x < 2) // Give Dealer 2 deck of cards and shuffle them
                {
                    dealer.GetDeck(deck.GiveDeck());
                    dealer.ShuffleActiveDeck();
                    x++;
                }


                while (true)  //TurnStarts
                {
                    Console.Clear();
                    dealer.GetCardToDealer();

                    // player Bet
                    int bet;
                    Console.WriteLine("How mutch you wanna bet?");


                    player.GetCard(dealer.GiveCard());
                    player.GetCard(dealer.GiveCard());

                    int DealerValue = StaticMethods.CountValue(dealer.ShowDealerHand());
                    int playerValue = StaticMethods.CountValue(player.ShowPlayerHand());

                    Console.WriteLine("        D e a l e r   H a n d");
                    GamePresentation.PrintCardHand(dealer.ShowDealerHand());
                    GamePresentation.PrintTotalValue(dealer.ShowDealerHand());
                    Console.WriteLine("\n");
                    Console.WriteLine("        P l a y e r   H a n d");
                    Console.WriteLine("      $$ " + player.balance + " $$");
                    GamePresentation.PrintCardHand(player.ShowPlayerHand());
                    GamePresentation.PrintTotalValue(player.ShowPlayerHand());

                    //ask player for new card
                    Console.WriteLine("You want one more card?");



                    if (Rules.TheWinner(StaticMethods.CountValue(player.ShowPlayerHand()), StaticMethods.CountValue(dealer.ShowDealerHand())))
                    { Console.WriteLine("player win"); }//player win 
                    else { Console.WriteLine("Dealer win"); } //Dealer win
                    Console.ReadLine();
                }


            }
        }
    }
}
