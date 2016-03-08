using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    class Dealer
    {
        List<Card> ActiveDeck;

        public int Balance { get; set; }

      public Dealer(int balance)
        {
            this.Balance = balance;
            this.ActiveDeck = new List<Card>();
        }
        public void GetDeck(List<Card> deck)
        {
            foreach (var item in deck)
            {
                ActiveDeck.Add(item);
            }
        }
        public void ShuffleActiveDeck()
        {
            Random random = new Random();
            Card cardHolder = new Card();

            foreach (var item in ActiveDeck)
            {
                int PointCard = random.Next(ActiveDeck.Count);
                int pointcard = random.Next(ActiveDeck.Count);

                cardHolder = ActiveDeck[PointCard];
                ActiveDeck.RemoveAt(PointCard);
                ActiveDeck.Add(cardHolder);
            }
        }
        public Card GiveCard()
        {
            Card card = new Card();
            card = ActiveDeck[0];
            ActiveDeck.RemoveAt(0);

            return card;

        } 

    }
}
