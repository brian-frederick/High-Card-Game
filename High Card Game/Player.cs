using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Card_Game
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public int Points { get; set; }

        public Player (string name)
        {
            Name = name;
            Hand = new List<Card>();
            Points = 0;
        }

        public Player() { }
    }
}
