using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    class Player
    {
        List<Card> PlayerHand;
        public int balance { get; set; }

        public Player(int balance)
        {
            this.balance = balance;
        }

        public void GetCard(Card newCard)
        {
            PlayerHand.Add(newCard);
        }

        public void ShowHand()
        {

        }

        public void NextCard()
        {

        }

        public void Pass()
        {

        }

        public void Bet()
        {

        }

        public List<Card> ShowPlayerHand()
        {
            return PlayerHand;
        }

    }
}
