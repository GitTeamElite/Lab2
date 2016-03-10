﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    class Deck
    {
        List<Card> DeckOfCard;

        public Deck()
        {
            this.DeckOfCard = new List<Card>();
            {

                for (int y = 0; y < 4; y++)
                {
                    for (int x = 0; x < 13; x++)
                    {
                        string CardType = StaticMethods.GetType(x);

                        if (x == 0) { DeckOfCard.Add(new Card(value: 1,aceValue : 11, color: StaticMethods.ReturnType(y), type: CardType)); }
                        else if (x > 9) { DeckOfCard.Add(new Card(10, 0, StaticMethods.ReturnType(y), CardType)); }
                        else { DeckOfCard.Add(new Card(x + 1, 0, StaticMethods.ReturnType(y), CardType)); }
                        
                    }
                }
            }
        }
        public List<Card> GiveDeck()
        {
            return DeckOfCard;
        }

    }
}
