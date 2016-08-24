using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> deck = Dealer.MakeDeck();

            foreach (var item in deck)
            {
                Console.WriteLine(item.CardName);
            }

            Console.ReadLine();

            Console.WriteLine("Ready to Deal? hit \"d\".");

            string s;
            do
            {
                Console.WriteLine(Dealer.Deal(deck).CardName);
                s = Console.ReadLine();
            } while (s == "d");

            Console.WriteLine("Thanks for playing.");

            foreach (var item in deck)
            {
                Console.WriteLine(item.CardName);
            }

            Console.ReadLine();
        }
    }
}
