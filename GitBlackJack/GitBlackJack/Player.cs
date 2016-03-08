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
            this.PlayerHand = new List<Card>();
        }

        public void GetCard(Card newCard)
        {
            PlayerHand.Add(newCard);
        }
        
        public bool Pass()
        {
            return true;
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
