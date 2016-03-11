using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
   public class Dealer
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

        internal void CheckActiveDeck(Deck deck,Dealer dealer)
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

        internal void DealerGetAllHisCards()
        {
            while (StaticMethods.CountValue(ShowDealerHand()) < 17 || StaticMethods.CountAceValue(ShowDealerHand())> 17)
            {
              GetCardToDealer();
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
        /// Gives a card from Dealers Active deck and removes it from deck
        /// </summary>
        /// <returns>Card</returns>
        public Card GiveCard()
        {
            Card card = new Card();
            card = ActiveDeck[0];
            ActiveDeck.RemoveAt(0);

            return card;

        } 
        /// <summary>
        /// Dealer give card to him self and removes it from active deck
        /// </summary>
        public void GetCardToDealer()
        {
            Card card = new Card();
            card = ActiveDeck[0];
            ActiveDeck.RemoveAt(0);

            DealerHand.Add(card);
        }
        /// <summary>
        /// Gives Dealers cards on hand
        /// </summary>
        /// <returns>List with cards</returns>
        public List<Card> ShowDealerHand()
        {
            return DealerHand;
        }
        /// <summary>
        /// Removes cards from hand
        /// </summary>
        public void ClearHand()
        {
            DealerHand.RemoveRange(0, DealerHand.Count);
        }
        /// <summary>
        /// Returns dealers Active deck
        /// </summary>
        /// <returns></returns>
        public List<Card> GiveActiveDeck()
        {
            return ActiveDeck;
        }
    }
}
