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


            while(!quit)
                {

                var x = 0;
                while (x < 2) // Give Dealer 2 deck of cards and shuffle them
                {
                    dealer.GetDeck(deck.GiveDeck());
                    dealer.ShuffleActiveDeck();
                    x++;
                }
                 
                //TurnStarts
                while (true)
                {
                    dealer.GetCardToDealer();
                    dealer.GetCardToDealer();

                    player.GetCard(dealer.GiveCard());
                    player.GetCard(dealer.GiveCard());

                    StaticMethods.CountValue(dealer.SHowDealerHand());
                }


            }
        }
    }
}
