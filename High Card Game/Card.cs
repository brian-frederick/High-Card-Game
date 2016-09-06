using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Card_Game
{
    public class Card
    {
        public Suits Suit { get; set; }
        public int Rank { get; set; }
        public string CardName { get; }

        public Card(Suits suit, int rank)
        {
            Suit = suit;
            Rank = rank;
            CardName = NameCard(suit, rank);
        }

        public enum Suits
        {
            Hearts,
            Diamonds,
            Spades,
            Clubs
        }
        
        /// <summary>
        /// assigns string name to a card from enum and int
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private string NameCard(Suits suit, int rank)
        {
            switch (rank)
            {
                case 11:
                    return "Jack of " + suit;
                case 12:
                    return "Queen of " + suit;
                case 13:
                    return "King of " + suit;
                case 14:
                    return "Ace of " + suit;
                default:
                    return rank + " of " + suit;
            }
        }
    }

    
}
