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
        List<Card> DealerHand;

        public int Balance { get; set; }

        public Dealer(int balance)
        {
            this.Balance = balance;
            this.ActiveDeck = new List<Card>();
            this.DealerHand = new List<Card>();
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

            for (int x = 0; x < ActiveDeck.Count; x++)
            {
                int PointCardX = random.Next(ActiveDeck.Count-1);
                int PointCardY = random.Next(ActiveDeck.Count-1);

                cardHolder = ActiveDeck[PointCardX];
                ActiveDeck[PointCardX] = ActiveDeck[PointCardY];
                ActiveDeck[PointCardY] = cardHolder;
            }
        }
        public Card GiveCard()
        {
            Card card = new Card();
            card = ActiveDeck[0];
            ActiveDeck.RemoveAt(0);

            return card;

        }
        public void GetCardToDealer()
        {
            Card card = new Card();
            card = ActiveDeck[0];
            ActiveDeck.RemoveAt(0);

            DealerHand.Add(card);
        }
        public List<Card> ShowDealerHand()
        {
            return DealerHand;
        }

    }
}
