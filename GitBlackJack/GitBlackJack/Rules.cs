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

        public Rules()
        {
            playAnotherCard = false;
        }

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
        public bool DealerValue()
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
        public bool SetBalance(play)
        {

        }
    }
}
