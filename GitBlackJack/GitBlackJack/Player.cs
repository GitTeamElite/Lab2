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
            GamePresentation.LOGG();
            Console.WriteLine($"How mutch you wanna bet? ---- Balance = {balance}");
            int bet = 1;
            do
            {
                if (bet > balance) { Console.WriteLine("You dont have so mutch $$ Cash $$ ;( "); }
                if (bet < 1) { Console.WriteLine("Seroius? you can do better! try again..."); }             
                int.TryParse(Console.ReadLine(), out bet);
            } while (bet > balance || bet <1);
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
        public void ClearHand()
        {
            PlayerHand.RemoveRange(0, PlayerHand.Count);
        }
    }
}
