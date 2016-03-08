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
                    int bet = player.Bet();

                    Console.Clear();
                    dealer.GetCardToDealer();

                    player.GetCard(dealer.GiveCard());
                    player.GetCard(dealer.GiveCard());

                    int DealerValue = StaticMethods.CountValue(dealer.ShowDealerHand());
                    int playerValue = StaticMethods.CountValue(player.ShowPlayerHand());

                    StaticMethods.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance);

                    //ask player for new card
                    bool go = true;
                    do
                    {
                        Console.WriteLine("You want one more card? y/n");
                        ConsoleKeyInfo key;
                        key = Console.ReadKey(true);
                        switch (key.KeyChar)
                        {
                            case 'y':
                                player.GetCard(dealer.GiveCard());
                             
                                StaticMethods.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance);
                                
                                break;
                            case 'n':
                                go = false;
                                break;
                            default:
                                break;
                        }
                        if (!Rules.Over21(StaticMethods.CountValue(player.ShowPlayerHand()))) { Console.WriteLine("Dealer win");  } 
                    } while (go);

                    while (Rules.GiveDealerCard(StaticMethods.CountValue(dealer.ShowDealerHand())))
                    {
                        StaticMethods.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance);
                        dealer.GetCardToDealer();

                        if (!Rules.Over21(StaticMethods.CountValue(dealer.ShowDealerHand()))) {    } // player win
                    }




                    int WIN = Rules.TheWinner(StaticMethods.CountValue(player.ShowPlayerHand()), StaticMethods.CountValue(dealer.ShowDealerHand()));
                    if (WIN == 1) { Console.WriteLine("player win"); }
                    else if (WIN == -1) { Console.WriteLine("Dealer win"); }                    
                    else if (WIN == 0 && player.numberOfCards() < 5) { Console.WriteLine("Dealer win"); }
                    else { Console.WriteLine("Dealer win"); }
                }


            }
        }
    }
}
