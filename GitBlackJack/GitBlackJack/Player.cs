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

        public int Bet()
        {
            Console.WriteLine("How mutch you wanna bet?");
            int bet = 0;
            do
            {
                int.TryParse(Console.ReadLine(), out bet);
            } while (bet > balance);
            return bet;

        }

        public List<Card> ShowPlayerHand()
        {
            return PlayerHand;
        }

        public int numberOfCards()
        {

            int number = 0;
            foreach (var item in PlayerHand)
            {
                number++;
            }
            return number;
        }

    }
}
