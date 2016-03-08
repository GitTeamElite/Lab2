using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    class Deck
    {
        List<Card> DeckOfCard;

        Deck()
        {
            this.DeckOfCard = new List<Card>();
            {
                for(int y =0;y<4;y++)
                {
                    for (int x =0;x<13;x++)
                    {
                        DeckOfCard.Add(new Card(x + 1, StaticMethods.ReturnType(y)));
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
