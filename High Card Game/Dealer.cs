using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Card_Game
{
    class Dealer
    {
        public static Card Deal(List<Card> deck)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, deck.Count);
            Card cardToDeal = deck[x];
            deck.Remove(deck[x]);
            return cardToDeal;
        }

        public static List<Card> MakeDeck()
        {
            List<Card> deck = new List<Card> { };

            for (int x = 0; x < 4; x++)
            {
                for (int y = 1; y < 15; y++)
                {
                    deck.Add(new Card((Card.Suits)x, y));
                }
            }

            return deck;
        }

    }


}
