using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    public class Player
    {
        public List<Card> PlayerHand;
        public List<Card> SplittHand;
        public int balance { get; set; }

        public Player(int balance)
        {
            this.balance = balance;
            this.PlayerHand = new List<Card>();
            this.SplittHand = new List<Card>();
        }
        /// <summary>
        /// Adds a card to player hand
        /// </summary>
        /// <param name="newCard"></param>
        public void GetCard(Card newCard)
        {
            PlayerHand.Add(newCard);
        }

        public bool Pass()
        {
            return true;
        }
        /// <summary>
        /// Asks for a bet from user- and returns it
        /// </summary>
        /// <returns>int bet</returns>
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
            } while (bet > balance || bet < 1);
            return bet;

        }
        /// <summary>
        /// Retuns palyers cards on hand
        /// </summary>
        /// <returns></returns>
        public List<Card> ShowPlayerHand()
        {
            return PlayerHand;
        }

        /// <summary>
        /// Counts the number of cards there is in the list
        /// </summary>
        /// <returns>int</returns>
        public int numberOfCards()
        {

            int number = 0;
            foreach (var item in PlayerHand)
            {
                number++;
            }
            return number;
        }
        /// <summary>
        /// Removing cards from player hand
        /// </summary>
        public void ClearHand()
        {
            PlayerHand.RemoveRange(0, PlayerHand.Count);
        }
        public void HitMe(Player player, Dealer dealer, int bet, bool splitt)
        {
            GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance, splitt, player);
            bool go = true;
            while (go && Rules.NotOver21(StaticMethods.CountValue(player.ShowPlayerHand())))
            {
                Console.WriteLine("You want one more card? y/n");
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case 'y':
                        player.GetCard(dealer.GiveCard());

                        GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance, splitt, player);

                        break;
                    case 'n':
                        go = false;
                        break;
                    default:
                        break;
                }
            }

        }
        public void HitMeSplitt(Player player, Dealer dealer, int bet, bool splitt)
        {
            GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance, splitt, player);
            bool go1 = true;
            bool go2 = true;
            while (go1 == true && go2 == true)
            {
                if (Rules.NotOver21(StaticMethods.CountValue(player.ShowPlayerHand())))
                {
                    if (go1)
                    {
                        Console.WriteLine("    --- Main Hand ---");
                        Console.WriteLine("You want one more card? y/n");
                        ConsoleKeyInfo key;
                        key = Console.ReadKey(true);
                        switch (key.KeyChar)
                        {
                            case 'y':
                                player.GetCard(dealer.GiveCard());

                                GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance, splitt, player);

                                break;
                            case 'n':
                                go1 = false;
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (Rules.NotOver21(StaticMethods.CountValue(player.SplittHand)))
                {
                    if (go2)
                    {
                        Console.WriteLine("    --- Split Hand ---");
                        Console.WriteLine("You want one more card? y/n");
                        ConsoleKeyInfo key;
                        key = Console.ReadKey(true);
                        switch (key.KeyChar)
                        {
                            case 'y':
                                player.SplittHand.Add(dealer.GiveCard());

                                GamePresentation.PrintGame(player.ShowPlayerHand(), dealer.ShowDealerHand(), bet, player.balance, splitt, player);

                                break;
                            case 'n':
                                go2 = false;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
