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

       
      public Dealer( )
        {
           
            this.ActiveDeck = new List<Card>();
            this.DealerHand = new List<Card>();
        }
        /// <summary>
        /// Count the value from cards sended in
        /// </summary>
        /// <returns>int total value</returns>
        public int CountCardsInActiveDeck()
        {
            int count = ActiveDeck.Count;
            return count;
        }
        /// <summary>
        /// Sends a sorted deck with 53 cards
        /// </summary>
        /// <param name="deck"></param>
        public void PutNewDeckToActiveDeck(List<Card> deck)
        {
            foreach (var item in deck)
            {
                ActiveDeck.Add(item);
            }
        }
        /// <summary>
        /// Shuffles Active deck 10000 times
        /// </summary>
        public void ShuffleActiveDeck()
        {
            Random random = new Random();
            Card cardHolder = new Card();

            for (int x =0;x<10000;x++)
            {
                int PointCardX = random.Next(ActiveDeck.Count-1);
                int PointCardY = random.Next(ActiveDeck.Count-1);

                cardHolder = ActiveDeck[PointCardX];
                ActiveDeck[PointCardX] = ActiveDeck[PointCardY];
                ActiveDeck[PointCardY] = cardHolder;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
        public void ClearHand()
        {
            DealerHand.RemoveRange(0, DealerHand.Count);
        }
        public List<Card> GiveActiveDeck()
        {
            return ActiveDeck;
        }
    }
}
