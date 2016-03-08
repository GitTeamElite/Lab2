using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    class Rules
    {
        private int totalValueCar { get; set; }
        private bool playAnotherCard { get; set; }
        private bool winner { get; set; }

        public Rules()
        {
            playAnotherCard = false;
            winner = false;
        }
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

        public int CardValue(Card card)
        {
            totalValueCar += card._Value;
            return totalValueCar;
        }
        public bool PlayCard()
        {
            if (totalValueCar < 17)
            {
                playAnotherCard = true;
                return playAnotherCard;
            }
            else
            {
                playAnotherCard = false;
                return playAnotherCard;
            }
        }
        public bool Win (int totalvaluecard)
        {
            if(playAnotherCard == false)
            {
                if(totalvaluecard > 21) { winner = false; }
                else if(totalvaluecard == 21) { winner = true;}
                
            }
            return winner;
        }
        public void TheWinner(int playerValue, int dealerValue)
        {

        }
    }
}
