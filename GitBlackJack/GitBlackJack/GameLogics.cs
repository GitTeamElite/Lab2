using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    public class GameLogics
    {
        bool go;
        Deck deck = new Deck();
        Player player = new Player(100);
        Dealer dealer = new Dealer();
        public GameLogics()
        { }
        /// <summary>
        /// Progess of the game - From start to end;
        /// </summary>
        public void RunGame()
        {
            if (dealer.CountCardsInActiveDeck() < 53)   // Checking if dealer have more then 53 cards in deck
            {
                var x = 0;
                while (x < 2) // Give Dealer 2 deck of cards and shuffle them
                {
                    dealer.PutNewDeckToActiveDeck(deck.GiveDeck());
                    dealer.ShuffleActiveDeck();
                    x++;
                }
            }
            GamePresentation.LOGG();
            Console.WriteLine("write \"check\" if you wanna see the decks. . . ");
            string check = Console.ReadLine();
            Console.Clear();

            // TEST Checking decks
            if (check == "check")
            {
                Console.WriteLine("Sorted deck");
                GamePresentation.PrintADeck(deck.GiveDeck());
                Console.WriteLine("\n\nDealer Deck");
                GamePresentation.PrintADeck(dealer.GiveActiveDeck());
                Console.ReadKey();
                Console.Clear();
            }

            dealer.ClearHand(); // Removing cards from previous round
            player.ClearHand();
            Console.Clear();

            int bet = player.Bet(); // Player set bet

            Console.Clear();

            dealer.GetCardToDealer();

            player.GetCard(dealer.GiveCard());
            player.GetCard(dealer.GiveCard());

            int DealerValue = StaticMethods.CountValue(dealer.ShowDealerHand());
            int playerValue = StaticMethods.CountValue(player.ShowPlayerHand());

            GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance);

            //ask player for new card
            bool go = true;
            bool lose = true;
            while (go || !Rules.NotOver21(StaticMethods.CountValue(player.ShowPlayerHand())))
            {
                Console.WriteLine("You want one more card? y/n");
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case 'y':
                        player.GetCard(dealer.GiveCard());

                        GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance);

                        break;
                    case 'n':
                        go = false;
                        break;
                    default:
                        break;
                }
            }
            if (Rules.NotOver21(StaticMethods.CountValue(player.ShowPlayerHand())))
            {

                {
                    go = true;
                    while (go)
                    {
                        GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance);

                        if (StaticMethods.CountValue(dealer.ShowDealerHand()) < 17)
                        {
                            dealer.GetCardToDealer();

                            Console.WriteLine("Press a key to see dealer next card");
                            Console.ReadKey();
                            GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance);
                            if (Rules.NotOver21(StaticMethods.CountValue(dealer.ShowDealerHand())))
                            {
                                lose = false;
                            }
                        }
                        else
                        {
                            go = false;
                        }
                    }
                }
                GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance);
                int WIN = Rules.TheWinner(StaticMethods.CountValue(player.ShowPlayerHand()), StaticMethods.CountValue(dealer.ShowDealerHand()));
                if (WIN == 1 || lose == false)
                {
                    Console.WriteLine("player win");
                    player.balance += bet;
                    Rules.Loose(player.balance);
                    RunGame();
                }
                else
                {
                    Console.WriteLine("Dealer win");
                    player.balance -= bet;
                    Rules.Loose(player.balance);
                    RunGame();
                }
                Console.ReadKey();
            }

        }
    }

}



