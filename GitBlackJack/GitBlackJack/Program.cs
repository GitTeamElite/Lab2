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
            Dealer dealer = new Dealer(1000);
            Deck deck = new Deck();

            var x = 0;
            while (x< 3)
            {
                dealer.GetDeck(deck.GiveDeck());
                dealer.ShuffleActiveDeck();
            }
        }
    }
}
