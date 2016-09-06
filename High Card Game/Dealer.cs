using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Card_Game
{
    class Dealer
    {
        /// <summary>
        /// deals random card from premade deck
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        public static Card Deal(List<Card> deck)
        {           
                Random rnd = new Random();
                int x = rnd.Next(0, deck.Count);
                Card cardToDeal = deck[x];
                deck.Remove(deck[x]);
                return cardToDeal;
        }

        /// <summary>
        /// builds ordered deck
        /// </summary>
        /// <returns></returns>
        public static List<Card> MakeDeck()
        {
            List<Card> deck = new List<Card> { };

            for (int x = 0; x < 4; x++)
            {
                for (int y = 1; y < 14; y++)
                {
                    deck.Add(new Card((Card.Suits)x, y));
                }
            }
            return deck;
        }

        /// <summary>
        /// creates List of players
        /// </summary>
        /// <param name="numberOfPlayers"></param>
        /// <returns></returns>
        public static List<Player> MakePlayers(int numberOfPlayers)
        {
            List<Player> players = new List<Player>();

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Player p = new Player("Player " + i);
                players.Add(p);
            }

            return players;
        }
    }


}
