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

        //  Class Rules:
        //  metod- DealerValue bool   (<17)
        //metod- Value bool  (>21)   PlayerValue>21= PlayerBalance -= PlayerBet; /// new round || dealerValue > 21 == Player Balance += bet*2; // new round;
        //metod- bool Playervalue > Dealervalue = PlayerBet*2
        //metod- Gameover    if balance = 0


        public static bool PlayCard(int totalValueCar)
        {
            if (totalValueCar > 0 && totalValueCar < 17){return true;}
            else{return false;}
        }
        public static bool BlackJack(int totalvaluecard)
        {
            bool check = false;

            if (totalvaluecard == 21) { check = true; }
            return check;
        }
        public static bool TheWinner(int playerValue, int dealerValue)
        {
           
            bool check = true; // Om true Player wins, om false dealer wins

            if (playerValue < 21 && playerValue < 21)
            {if (playerValue > dealerValue) { check = false; }}
            return check;
        }
    }
}
