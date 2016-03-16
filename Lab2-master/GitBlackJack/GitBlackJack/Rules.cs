using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    public static class Rules
    {
        //1. The one closest but not over 21 wins the round.
        //2. Anyone over 21, are bust and loses the round.
        //3. Equal value dealer wins if player less than 5 cards.
        //4. Dealer must draw to 17.
        //5. Face cards(i.e.Knights, Queens and Kings) have the value of 10.
        //6. Ace has either value of 1 or 11

        /// <summary>
        /// Check if player can get another card
        /// </summary>
        /// <param name="totalValueCar"></param>
        /// <returns></returns>
        public static bool GiveDealerCard(int totalValueCar)
        {
            if (totalValueCar < 17) { return true; }
            else { return false; }
        }

        /// <summary>
        /// Check if Black Jack
        /// </summary>
        /// <param name="totalvaluecard"></param>
        /// <returns></returns>
        public static bool BlackJack(int totalvaluecard)
        {
            bool check = false;

            if (totalvaluecard == 21) { check = true; }
            return check;
        }

        /// <summary>
        /// Check if total cards points are over 21
        /// </summary>
        /// <param name="playerValue"></param>
        /// <param name="dealerValue"></param>
        /// <returns></returns>
        public static bool NotOver21(int totalvaluecard)
        {
            if (totalvaluecard < 22)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Compare total amount of points and return who is the winner
        /// </summary>
        /// <param name="playerValue"></param>
        /// <param name="dealerValue"></param>
        /// <returns></returns>
        public static bool PlayerWin(int playerValue, int dealerValue)
        {

            if (playerValue > dealerValue) { return true; }
            else { return false; }

        }
        public static bool Loose(int balance)
        {
            if (balance < 1) { Console.WriteLine("You are out of cash.... GAMVEOVER"); Console.ReadKey(); Environment.Exit(-1); }
            Console.WriteLine("Press ESC to exit or press other key for next round");
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    return false;
                default:
                    return true;

            }
        }
        public static void WinManager(bool Win, bool WinSplit, int bet, Player player, bool split)
        {
            if (split)
            {
                if (WinSplit) { player.balance += bet; }
                else { player.balance -= bet; }
            }

            if (Win) { player.balance += bet; }
            else { player.balance -= bet; }
        }
        public static bool SplittPosible(List<Card> Input, Player player, int bet)
        {
            if (Input[0]._Value == Input[1]._Value && bet * 2 > player.balance)
            {
                GamePresentation.ToLittleCashToSplitt();
                return false;
            }
            if (Input[0]._Value == Input[1]._Value && bet * 2 < player.balance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
